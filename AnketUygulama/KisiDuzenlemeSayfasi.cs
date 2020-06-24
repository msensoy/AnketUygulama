using FireSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AnketUygulama
{
    public partial class KisiDuzenlemeSayfasi : Form
    {
        FireBaseConnection _connection;
        Person person;
        List<Hobby> _hobbyList;
        string[] _personHobbyList;

        public KisiDuzenlemeSayfasi(FireBaseConnection connection)
        {
            InitializeComponent();
            
            _connection = connection;
            HobileriYukle();
            grbGuncelle.Visible = false;
            grbGuncelle.Enabled = false;
            dtpDogumTarihi.MaxDate = DateTime.Now.AddYears(-18);
            dtpDogumTarihi.MinDate = DateTime.Now.AddYears(-100);
        }

        private async void HobileriYukle()
        {
            _connection.client = new FireSharp.FirebaseClient(_connection.config);
            _connection.response = await _connection.client.GetAsync("Hobbies/");
            var responseHobbies = _connection.response.Body.ToString();
            var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, Hobby>>(responseHobbies);
            _hobbyList = dict.Select(x => x.Value).ToList();
        }

        private async void btnSorgula_Click(object sender, EventArgs e)
        {
            if (txtSorguTC.Text.Length !=11)
            {
                EkraniTemizle();
                MessageBox.Show("Lütfen TC numarasını kontrol ediniz!");
                return;
            }
            try
            {
                _connection.client = new FireSharp.FirebaseClient(_connection.config);
                _connection.response = await _connection.client.GetAsync("Persons/");
                var responsePersons = _connection.response.Body.ToString();
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, Person>>(responsePersons);
                List<Person> personList = dict.Select(x => x.Value).ToList();
          
                //con.response = await con.client.GetAsync("Persons/" + textBox1.Text);
                //user = con.response.ResultAs<User>();
                if (personList != null)
                {
                    person = personList.Where(x => x.TC == txtSorguTC.Text).FirstOrDefault();
                    if (person != null)
                    {
                        grbGuncelle.Visible = true;
                        grbGuncelle.Enabled = true;

                        txtAd.Text = person.FirstName;
                        txtSoyad.Text = person.LastName;
                        txtPhone.Text = person.Phone;

                        lstHobiler.Items.Clear();
                        if (person.Hobbies != null)
                        {
                            _personHobbyList = person.Hobbies.Split(' ').ToArray();
                        }
                        else
                        {
                            _personHobbyList = new string[] { "" };
                        }                        
                        lstHobiler.Items.AddRange(_personHobbyList.ToArray());
                        dtpDogumTarihi.Value = DateTime.Parse(person.Birthdate);
                    }
                    else
                    {
                        EkraniTemizle();
                        MessageBox.Show("Aranılan kişi malesef kayıtlarda yok");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            person.FirstName = txtAd.Text;
            person.LastName = txtSoyad.Text;
            person.Phone = txtPhone.Text;
            person.UpdatedTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            person.Birthdate = dtpDogumTarihi.Value.ToString("dd.MM.yyyy");
            person.Hobbies = ""; // hobileri temizle aşağıda tekrar yükle

            for (int i = 0; i < lstHobiler.Items.Count; i++)
            {
                if (i == lstHobiler.Items.Count - 1)
                {
                    person.Hobbies += lstHobiler.Items[i].ToString();
                }
                else
                {
                    person.Hobbies += lstHobiler.Items[i].ToString() + " ";
                }
            }

            var update = _connection.client.Update(@"Persons/" + person.TC, person);
            if (update.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var delete = _connection.client.Delete(@"Persons/" + person.TC);
            if (delete.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Silme işlemi Başarılı");
            }
            EkraniTemizle();
        }
        void EkraniTemizle()
        {
            grbGuncelle.Visible = false;
            grbGuncelle.Enabled = false;
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtPhone.Text = "";
            dtpDogumTarihi.Value = dtpDogumTarihi.MaxDate;
        }

        private void btnHobiDuzenle_Click(object sender, EventArgs e)
        {
            KisiHobiEklePenceresi kisiHobiEklePenceresi = new KisiHobiEklePenceresi(_hobbyList, _personHobbyList);
            kisiHobiEklePenceresi.Show();
            kisiHobiEklePenceresi.FormClosed += KisiHobiEklePenceresi_FormClosed;
        }

        private void KisiHobiEklePenceresi_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            _personHobbyList = (sender as KisiHobiEklePenceresi)._personHobbiesNew;
            if(_personHobbyList != null)
            {
                lstHobiler.Items.Clear();
                lstHobiler.Items.AddRange(_personHobbyList);
            }
        }

        private void txtSorguTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

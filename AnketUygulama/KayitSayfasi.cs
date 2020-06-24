using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AnketUygulama
{
    public partial class KayitSayfasi : Form
    {
        FireBaseConnection _connection;
        Person person;
        private string[] _personHobbyList;
        private List<Hobby> _hobbyList;

        public KayitSayfasi(FireBaseConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _personHobbyList = new string[] { "" };
            HobileriYukle();
            dtpDogumTarihi.MaxDate = DateTime.Now.AddYears(-18);
            dtpDogumTarihi.MinDate = DateTime.Now.AddYears(-100);
        }

        private async void HobileriYukle()
        {
            try
            {
                _connection.client = new FireSharp.FirebaseClient(_connection.config);
                _connection.response = await _connection.client.GetAsync("Hobbies/");
                var responseHobbies = _connection.response.Body.ToString();
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, Hobby>>(responseHobbies);
                _hobbyList = dict.Select(x => x.Value).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTC.Text.Length != 11)
                {
                    MessageBox.Show("Lütfen TC numarasını kontrol ediniz!");
                    return;
                }
                if (lstHobiler.Items.Count == 0)
                {
                    MessageBox.Show("En az bir adet hobi ekleyiniz!");
                    return;
                }
                _connection.client = new FireSharp.FirebaseClient(_connection.config);
                _connection.response = _connection.client.Get("Persons/");
                var responsePersons = _connection.response.Body.ToString();

                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, Person>>(responsePersons);
                if (dict != null)
                {
                    List<Person> personList = dict.Select(x => x.Value).ToList();
                    if (personList.Any(x => x.TC == txtTC.Text))
                    {
                        MessageBox.Show("Girilen TC numarası sistemde zaten kayıtlı! Anasayfadan düzenleme işlemlerini yapabilirsiniz.");
                        return;
                    }
                }
               
                person = new Person()
                {
                    TC = txtTC.Text,
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    Phone = txtPhone.Text,
                    CreatedTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                    Birthdate = dtpDogumTarihi.Value.ToString("dd.MM.yyyy")
            };
                lstHobiler.Items.Clear();
                lstHobiler.Items.AddRange(_personHobbyList.ToArray());
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

                var set = _connection.client.Set("Persons/" + person.TC, person);
                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Bilgiler sisteme kaydedilmiştir.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kaydetme sırasında bir hata oluştu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            lstHobiler.Items.Clear();
            lstHobiler.Items.AddRange(_personHobbyList);
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

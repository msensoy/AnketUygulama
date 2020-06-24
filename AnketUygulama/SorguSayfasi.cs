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
    public partial class SorguSayfasi : Form
    {
        FireBaseConnection _connection;
        List<Person> _personList;
        List<Hobby> _hobbyList;
        public SorguSayfasi(FireBaseConnection connection)
        {
            _connection = connection;
            InitializeComponent();
            VerileriYükle();
           dtpKisitTarih.Format = DateTimePickerFormat.Custom;
           dtpKisitTarih.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void VerileriYükle()
        {
            try
            {
                //DataGridView'a Kişileri bilgileri ile yükler
                _connection.client = new FireSharp.FirebaseClient(_connection.config);
                _connection.response =  _connection.client.Get("Persons/");
                var responsePersons = _connection.response.Body.ToString();
                var dictPerson = new JavaScriptSerializer().Deserialize<Dictionary<string, Person>>(responsePersons);
                _personList = dictPerson.Select(x => x.Value).ToList();
                dgvListe.DataSource = _personList.Select(x => new
                { AdSoyad = x.FullName, Telefon = x.Phone, DogumTarihi = x.Birthdate, Hobiler = x.Hobbies, OlusturulmaTarihi = x.CreatedTime }).ToList();
                dgvListe.Columns[0].HeaderText = "Ad Soyad";
                dgvListe.Columns[1].HeaderText = "Telefon";
                dgvListe.Columns[2].HeaderText = "Doğum Tarihi";
                dgvListe.Columns[3].HeaderText = "Hobiler";
                dgvListe.Columns[3].Width = 200;
                dgvListe.Columns[4].HeaderText = "Oluşturulma Tarihi";
                dgvListe.Columns[4].Width = 150;

                //Combobox'a Hobileri yükler
                _connection.response =  _connection.client.Get("Hobbies/");
                var responseHobbies = _connection.response.Body.ToString();
                var dictHobby = new JavaScriptSerializer().Deserialize<Dictionary<string, Hobby>>(responseHobbies);
                _hobbyList = dictHobby.Select(x => x.Value).ToList();
                cmbHobiler.DisplayMember = "HobbyName";
                cmbHobiler.DataSource = _hobbyList;
                cmbHobiler.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu.");
            }
        }
        private void btnKisileriGetir_Click(object sender, EventArgs e)
        {
            if (cmbHobiler.SelectedIndex > -1 )
            {
                var hobi = (cmbHobiler.SelectedItem as Hobby).HobbyName;
                var personWithHobby = _personList.Where(x => x.Hobbies != null).Where(x => x.Hobbies.Contains(hobi)).ToList();
                dgvListe.DataSource = personWithHobby.Where(x => DateTime.Parse(x.CreatedTime) < dtpKisitTarih.Value).Select(x => new
                { AdSoyad = x.FullName, Telefon = x.Phone, DogumTarihi = x.Birthdate, Hobiler = x.Hobbies, OlusturulmaTarihi = x.CreatedTime }).ToList(); //AnonymousType Tanımlandı
            }
            
        }
    }
}

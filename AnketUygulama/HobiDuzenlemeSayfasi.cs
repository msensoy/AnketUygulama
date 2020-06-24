using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AnketUygulama
{
    public partial class HobiDuzenlemeSayfasi : Form
    {
        FireBaseConnection _connection;
        List<Hobby> _hobbyList;
        public HobiDuzenlemeSayfasi(FireBaseConnection connection)
        {
            _connection = connection;
            InitializeComponent();
            HobileriYukle();
        }

        private void HobileriYukle()
        {
            try
            {
                _connection.client = new FireSharp.FirebaseClient(_connection.config);
                _connection.response = _connection.client.Get("Hobbies/");
                var responseHobbies = _connection.response.Body.ToString();
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, Hobby>>(responseHobbies);
                _hobbyList = dict.Select(x => x.Value).ToList();
                lstHobiler.DataSource = _hobbyList;
                lstHobiler.DisplayMember = "HobbyName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnHobiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hobbyList.Any(x => x.HobbyName == txtHobiAdi.Text))
                {
                    MessageBox.Show(txtHobiAdi.Text + " isminde bir hobi zaten var!");
                }
                Hobby hobby = new Hobby()
                {
                    HobbyName = txtHobiAdi.Text
                };
                _connection.client = new FireSharp.FirebaseClient(_connection.config);
                var set = _connection.client.Set("Hobbies/" + hobby.HobbyName, hobby);
                if (set.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show(hobby.HobbyName + " adında yeni bir hobi eklendi.");
                    HobileriYukle();
                }
                else
                {
                    MessageBox.Show("Kaydetme sırasında bir hata oluştu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }

        private void btnHobiSil_Click(object sender, EventArgs e)
        {
            try
            {
                var silinecek = (lstHobiler.SelectedItem as Hobby).HobbyName;
                var delete = _connection.client.Delete(@"Hobbies/" + silinecek);
                if (delete.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Silme işlemi Başarılı");
                    HobileriYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtHobiAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}

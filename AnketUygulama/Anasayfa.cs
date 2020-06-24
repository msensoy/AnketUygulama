using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketUygulama
{
    public partial class Anasayfa : Form
    {
        FireBaseConnection connection;
        public Anasayfa()
        {
            InitializeComponent();
            connection = new FireBaseConnection();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            KayitSayfasi kayitSayfasi = new KayitSayfasi(connection);
            kayitSayfasi.Show();
            kayitSayfasi.FormClosed += AnketSayfasi_FormClosed;
            this.Hide();
        }

        private void AnketSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnKisiDuzenle_Click(object sender, EventArgs e)
        {
            KisiDuzenlemeSayfasi kisiDuzenlemeSayfasi = new KisiDuzenlemeSayfasi(connection);
            kisiDuzenlemeSayfasi.Show();
            kisiDuzenlemeSayfasi.FormClosed += SorguSayfasi_FormClosed;
            this.Hide();
        }

        private void SorguSayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnHobiDuzenle_Click(object sender, EventArgs e)
        {
            HobiDuzenlemeSayfasi hobiDuzenlemeSayfasi = new HobiDuzenlemeSayfasi(connection);
            hobiDuzenlemeSayfasi.Show();
            hobiDuzenlemeSayfasi.FormClosed += HobiEklemeSayfası_FormClosed;
            this.Hide();
        }

        private void HobiEklemeSayfası_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            SorguSayfasi sorguSayfasi = new SorguSayfasi(connection);
            sorguSayfasi.Show();
            sorguSayfasi.FormClosed += SorguSayfasi_FormClosed1;
            this.Hide();
        }

        private void SorguSayfasi_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))+ "\\Resources\\icon.ico";


            NotifyIcon icon = new NotifyIcon();
            icon.Icon = new Icon(path);
            icon.Visible = true;
            icon.Text = "Kişi-Hobi Uygulaması";
            icon.MouseClick += Icon_MouseClick;
        }

        #region ToolStripMenü - SagTikMenu
        private void Icon_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Uygulama çalışıyor.");
        }


        private void maviToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void maviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Button>().ToList().ForEach(x => x.BackColor = Color.LightBlue);
        }

        private void kırmızıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Button>().ToList().ForEach(x => x.BackColor = Color.Red);
        }

        private void sarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Button>().ToList().ForEach(x => x.BackColor = Color.LightYellow);
        }

        private void yeşilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Button>().ToList().ForEach(x => x.BackColor = Color.LightGreen);
        }

        private void yeniKayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            KayitSayfasi kayitSayfasi = new KayitSayfasi(connection);
            kayitSayfasi.Show();
            kayitSayfasi.FormClosed += AnketSayfasi_FormClosed;
            this.Hide();
        }

        private void sorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SorguSayfasi sorguSayfasi = new SorguSayfasi(connection);
            sorguSayfasi.Show();
            sorguSayfasi.FormClosed += SorguSayfasi_FormClosed1;
            this.Hide();
        }

        private void kişiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiDuzenlemeSayfasi kisiDuzenlemeSayfasi = new KisiDuzenlemeSayfasi(connection);
            kisiDuzenlemeSayfasi.Show();
            kisiDuzenlemeSayfasi.FormClosed += SorguSayfasi_FormClosed;
            this.Hide();
        }

        private void hobiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HobiDuzenlemeSayfasi hobiDuzenlemeSayfasi = new HobiDuzenlemeSayfasi(connection);
            hobiDuzenlemeSayfasi.Show();
            hobiDuzenlemeSayfasi.FormClosed += HobiEklemeSayfası_FormClosed;
            this.Hide();
        }
        #endregion

        #region Menu
        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SorguSayfasi sorguSayfasi = new SorguSayfasi(connection);
            sorguSayfasi.Show();
            sorguSayfasi.FormClosed += SorguSayfasi_FormClosed1;
            this.Hide();
        }
       

        private void kişiBilgileriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiDuzenlemeSayfasi kisiDuzenlemeSayfasi = new KisiDuzenlemeSayfasi(connection);
            kisiDuzenlemeSayfasi.Show();
            kisiDuzenlemeSayfasi.FormClosed += SorguSayfasi_FormClosed;
            this.Hide();
        }

        private void hobileriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HobiDuzenlemeSayfasi hobiDuzenlemeSayfasi = new HobiDuzenlemeSayfasi(connection);
            hobiDuzenlemeSayfasi.Show();
            hobiDuzenlemeSayfasi.FormClosed += HobiEklemeSayfası_FormClosed;
            this.Hide();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitSayfasi kayitSayfasi = new KayitSayfasi(connection);
            kayitSayfasi.Show();
            kayitSayfasi.FormClosed += AnketSayfasi_FormClosed;
            this.Hide();
        }
        #endregion
        #region Arac Cubugu
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            KisiDuzenlemeSayfasi kisiDuzenlemeSayfasi = new KisiDuzenlemeSayfasi(connection);
            kisiDuzenlemeSayfasi.Show();
            kisiDuzenlemeSayfasi.FormClosed += SorguSayfasi_FormClosed;
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HobiDuzenlemeSayfasi hobiDuzenlemeSayfasi = new HobiDuzenlemeSayfasi(connection);
            hobiDuzenlemeSayfasi.Show();
            hobiDuzenlemeSayfasi.FormClosed += HobiEklemeSayfası_FormClosed;
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            KayitSayfasi kayitSayfasi = new KayitSayfasi(connection);
            kayitSayfasi.Show();
            kayitSayfasi.FormClosed += AnketSayfasi_FormClosed;
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SorguSayfasi sorguSayfasi = new SorguSayfasi(connection);
            sorguSayfasi.Show();
            sorguSayfasi.FormClosed += SorguSayfasi_FormClosed1;
            this.Hide();
        }
        #endregion

    }
}

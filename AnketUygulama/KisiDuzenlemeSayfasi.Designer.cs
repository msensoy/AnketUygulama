namespace AnketUygulama
{
    partial class KisiDuzenlemeSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtSorguTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbGuncelle = new System.Windows.Forms.GroupBox();
            this.btnHobiDuzenle = new System.Windows.Forms.Button();
            this.lstHobiler = new System.Windows.Forms.ListBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grbGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(174, 65);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 23);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtSorguTC
            // 
            this.txtSorguTC.Location = new System.Drawing.Point(146, 39);
            this.txtSorguTC.MaxLength = 11;
            this.txtSorguTC.Name = "txtSorguTC";
            this.txtSorguTC.Size = new System.Drawing.Size(155, 20);
            this.txtSorguTC.TabIndex = 0;
            this.txtSorguTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSorguTC_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(212, 299);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 44);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Bilgileri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(121, 66);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(159, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hobiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ad";
            // 
            // grbGuncelle
            // 
            this.grbGuncelle.Controls.Add(this.label12);
            this.grbGuncelle.Controls.Add(this.label11);
            this.grbGuncelle.Controls.Add(this.label10);
            this.grbGuncelle.Controls.Add(this.label9);
            this.grbGuncelle.Controls.Add(this.label8);
            this.grbGuncelle.Controls.Add(this.btnHobiDuzenle);
            this.grbGuncelle.Controls.Add(this.lstHobiler);
            this.grbGuncelle.Controls.Add(this.txtPhone);
            this.grbGuncelle.Controls.Add(this.label7);
            this.grbGuncelle.Controls.Add(this.dtpDogumTarihi);
            this.grbGuncelle.Controls.Add(this.label6);
            this.grbGuncelle.Controls.Add(this.txtAd);
            this.grbGuncelle.Controls.Add(this.txtSoyad);
            this.grbGuncelle.Controls.Add(this.btnSil);
            this.grbGuncelle.Controls.Add(this.btnGuncelle);
            this.grbGuncelle.Controls.Add(this.label5);
            this.grbGuncelle.Controls.Add(this.label4);
            this.grbGuncelle.Controls.Add(this.label3);
            this.grbGuncelle.Location = new System.Drawing.Point(25, 111);
            this.grbGuncelle.Name = "grbGuncelle";
            this.grbGuncelle.Size = new System.Drawing.Size(346, 363);
            this.grbGuncelle.TabIndex = 3;
            this.grbGuncelle.TabStop = false;
            this.grbGuncelle.Text = "Kişi Bilgileri";
            // 
            // btnHobiDuzenle
            // 
            this.btnHobiDuzenle.Location = new System.Drawing.Point(31, 218);
            this.btnHobiDuzenle.Name = "btnHobiDuzenle";
            this.btnHobiDuzenle.Size = new System.Drawing.Size(54, 46);
            this.btnHobiDuzenle.TabIndex = 12;
            this.btnHobiDuzenle.Text = "Hobileri Düzenle";
            this.btnHobiDuzenle.UseVisualStyleBackColor = true;
            this.btnHobiDuzenle.Click += new System.EventHandler(this.btnHobiDuzenle_Click);
            // 
            // lstHobiler
            // 
            this.lstHobiler.FormattingEnabled = true;
            this.lstHobiler.Location = new System.Drawing.Point(121, 182);
            this.lstHobiler.Name = "lstHobiler";
            this.lstHobiler.Size = new System.Drawing.Size(159, 82);
            this.lstHobiler.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 138);
            this.txtPhone.Mask = "999-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(159, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Doğum Tarihi";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(121, 102);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(159, 20);
            this.dtpDogumTarihi.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(121, 299);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 44);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Kişiyi Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = ":";
            // 
            // KisiDuzenlemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSorguTC);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.grbGuncelle);
            this.Name = "KisiDuzenlemeSayfasi";
            this.Text = "Kişi Bilgileri Düzenleme";
            this.grbGuncelle.ResumeLayout(false);
            this.grbGuncelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox txtSorguTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ListBox lstHobiler;
        private System.Windows.Forms.Button btnHobiDuzenle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}
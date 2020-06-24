namespace AnketUygulama
{
    partial class HobiDuzenlemeSayfasi
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
            this.grbHobi = new System.Windows.Forms.GroupBox();
            this.btnHobiEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHobiAdi = new System.Windows.Forms.TextBox();
            this.lstHobiler = new System.Windows.Forms.ListBox();
            this.btnHobiSil = new System.Windows.Forms.Button();
            this.grbHobi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHobi
            // 
            this.grbHobi.Controls.Add(this.btnHobiEkle);
            this.grbHobi.Controls.Add(this.label8);
            this.grbHobi.Controls.Add(this.txtHobiAdi);
            this.grbHobi.Location = new System.Drawing.Point(12, 23);
            this.grbHobi.Name = "grbHobi";
            this.grbHobi.Size = new System.Drawing.Size(222, 153);
            this.grbHobi.TabIndex = 13;
            this.grbHobi.TabStop = false;
            this.grbHobi.Text = "Hobi";
            // 
            // btnHobiEkle
            // 
            this.btnHobiEkle.Location = new System.Drawing.Point(142, 72);
            this.btnHobiEkle.Name = "btnHobiEkle";
            this.btnHobiEkle.Size = new System.Drawing.Size(70, 38);
            this.btnHobiEkle.TabIndex = 10;
            this.btnHobiEkle.Text = "Ekle";
            this.btnHobiEkle.UseVisualStyleBackColor = true;
            this.btnHobiEkle.Click += new System.EventHandler(this.btnHobiEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hobi Adı :";
            // 
            // txtHobiAdi
            // 
            this.txtHobiAdi.Location = new System.Drawing.Point(91, 36);
            this.txtHobiAdi.MaxLength = 20;
            this.txtHobiAdi.Name = "txtHobiAdi";
            this.txtHobiAdi.Size = new System.Drawing.Size(121, 20);
            this.txtHobiAdi.TabIndex = 9;
            this.txtHobiAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHobiAdi_KeyPress);
            // 
            // lstHobiler
            // 
            this.lstHobiler.FormattingEnabled = true;
            this.lstHobiler.Location = new System.Drawing.Point(12, 203);
            this.lstHobiler.Name = "lstHobiler";
            this.lstHobiler.Size = new System.Drawing.Size(222, 238);
            this.lstHobiler.TabIndex = 14;
            // 
            // btnHobiSil
            // 
            this.btnHobiSil.Location = new System.Drawing.Point(164, 447);
            this.btnHobiSil.Name = "btnHobiSil";
            this.btnHobiSil.Size = new System.Drawing.Size(70, 38);
            this.btnHobiSil.TabIndex = 15;
            this.btnHobiSil.Text = "Hobi Sil";
            this.btnHobiSil.UseVisualStyleBackColor = true;
            this.btnHobiSil.Click += new System.EventHandler(this.btnHobiSil_Click);
            // 
            // HobiDuzenlemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 510);
            this.Controls.Add(this.btnHobiSil);
            this.Controls.Add(this.lstHobiler);
            this.Controls.Add(this.grbHobi);
            this.Name = "HobiDuzenlemeSayfasi";
            this.Text = "Hobiler";
            this.grbHobi.ResumeLayout(false);
            this.grbHobi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHobi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHobiAdi;
        private System.Windows.Forms.Button btnHobiEkle;
        private System.Windows.Forms.ListBox lstHobiler;
        private System.Windows.Forms.Button btnHobiSil;
    }
}
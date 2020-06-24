namespace AnketUygulama
{
    partial class SorguSayfasi
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHobiler = new System.Windows.Forms.ComboBox();
            this.btnKisileriGetir = new System.Windows.Forms.Button();
            this.dtpKisitTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(12, 115);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(691, 323);
            this.dgvListe.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hobi İsmi";
            // 
            // cmbHobiler
            // 
            this.cmbHobiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHobiler.FormattingEnabled = true;
            this.cmbHobiler.Location = new System.Drawing.Point(79, 48);
            this.cmbHobiler.Name = "cmbHobiler";
            this.cmbHobiler.Size = new System.Drawing.Size(121, 21);
            this.cmbHobiler.TabIndex = 22;
            // 
            // btnKisileriGetir
            // 
            this.btnKisileriGetir.Location = new System.Drawing.Point(206, 48);
            this.btnKisileriGetir.Name = "btnKisileriGetir";
            this.btnKisileriGetir.Size = new System.Drawing.Size(75, 23);
            this.btnKisileriGetir.TabIndex = 21;
            this.btnKisileriGetir.Text = "Kişileri Getir";
            this.btnKisileriGetir.UseVisualStyleBackColor = true;
            this.btnKisileriGetir.Click += new System.EventHandler(this.btnKisileriGetir_Click);
            // 
            // dtpKisitTarih
            // 
            this.dtpKisitTarih.Location = new System.Drawing.Point(503, 53);
            this.dtpKisitTarih.Name = "dtpKisitTarih";
            this.dtpKisitTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpKisitTarih.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Oluşturma Tarihi İtibaren: ";
            // 
            // SorguSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpKisitTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHobiler);
            this.Controls.Add(this.btnKisileriGetir);
            this.Controls.Add(this.dgvListe);
            this.Name = "SorguSayfasi";
            this.Text = "Sorgu Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHobiler;
        private System.Windows.Forms.Button btnKisileriGetir;
        private System.Windows.Forms.DateTimePicker dtpKisitTarih;
        private System.Windows.Forms.Label label1;
    }
}
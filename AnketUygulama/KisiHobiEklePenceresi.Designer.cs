namespace AnketUygulama
{
    partial class KisiHobiEklePenceresi
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
            this.flwPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flwPanel
            // 
            this.flwPanel.Location = new System.Drawing.Point(12, 47);
            this.flwPanel.Name = "flwPanel";
            this.flwPanel.Size = new System.Drawing.Size(303, 171);
            this.flwPanel.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(89, 224);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Değişiklikleri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // KisiHobiEklePenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 274);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.flwPanel);
            this.Name = "KisiHobiEklePenceresi";
            this.Text = "Kişi Hobi Düzenleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwPanel;
        private System.Windows.Forms.Button btnKaydet;
    }
}
namespace kafeSistemi
{
    partial class SiparisForm
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
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapOdendi = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lstAdisyon = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUrunler
            // 
            this.cbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(11, 23);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(233, 28);
            this.cbUrunler.TabIndex = 1;
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(11, 85);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(49, 26);
            this.nudAdet.TabIndex = 2;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(118, 85);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 33);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Siparişi Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapOdendi
            // 
            this.btnHesapOdendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHesapOdendi.Location = new System.Drawing.Point(11, 482);
            this.btnHesapOdendi.Name = "btnHesapOdendi";
            this.btnHesapOdendi.Size = new System.Drawing.Size(233, 38);
            this.btnHesapOdendi.TabIndex = 4;
            this.btnHesapOdendi.Text = "Ödemeyi Al / Masayı Kapat ";
            this.btnHesapOdendi.UseVisualStyleBackColor = true;
            this.btnHesapOdendi.Click += new System.EventHandler(this.btnHesapOdendi_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(12, 441);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(168, 26);
            this.lblToplamTutar.TabIndex = 5;
            this.lblToplamTutar.Text = "Toplam: 0.00 TL";
            // 
            // lstAdisyon
            // 
            this.lstAdisyon.FormattingEnabled = true;
            this.lstAdisyon.Location = new System.Drawing.Point(250, 12);
            this.lstAdisyon.Name = "lstAdisyon";
            this.lstAdisyon.Size = new System.Drawing.Size(291, 511);
            this.lstAdisyon.TabIndex = 6;
            this.lstAdisyon.DoubleClick += new System.EventHandler(this.lstAdisyon_DoubleClick);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 532);
            this.Controls.Add(this.lstAdisyon);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.btnHesapOdendi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cbUrunler);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapOdendi;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.ListBox lstAdisyon;
    }
}
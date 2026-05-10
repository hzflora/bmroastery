namespace kafeSistemi
{
    partial class YoneticiForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tbUrunAdi = new System.Windows.Forms.TextBox();
            this.tbUrunFiyati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiltre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblCiroSonuc = new System.Windows.Forms.Label();
            this.btnCiroHesapla = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.btnMasaSil = new System.Windows.Forms.Button();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.dgvCiroDetay = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiroDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 416);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbKategori);
            this.tabPage1.Controls.Add(this.cbFiltre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.dgvUrunler);
            this.tabPage1.Controls.Add(this.tbUrunFiyati);
            this.tabPage1.Controls.Add(this.tbUrunAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCiroDetay);
            this.tabPage2.Controls.Add(this.btnCiroHesapla);
            this.tabPage2.Controls.Add(this.lblCiroSonuc);
            this.tabPage2.Controls.Add(this.dtpTarih);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMasaSil);
            this.tabPage3.Controls.Add(this.btnMasaEkle);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(637, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(358, 36);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.Size = new System.Drawing.Size(458, 320);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(14, 286);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(118, 286);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(98, 35);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(222, 286);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 35);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tbUrunAdi
            // 
            this.tbUrunAdi.Location = new System.Drawing.Point(118, 36);
            this.tbUrunAdi.MaxLength = 100;
            this.tbUrunAdi.Name = "tbUrunAdi";
            this.tbUrunAdi.Size = new System.Drawing.Size(121, 20);
            this.tbUrunAdi.TabIndex = 4;
            // 
            // tbUrunFiyati
            // 
            this.tbUrunFiyati.Location = new System.Drawing.Point(118, 94);
            this.tbUrunFiyati.Name = "tbUrunFiyati";
            this.tbUrunFiyati.Size = new System.Drawing.Size(121, 20);
            this.tbUrunFiyati.TabIndex = 4;
            this.tbUrunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUrunFiyati_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Fiyatı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Kategorisi";
            // 
            // cbFiltre
            // 
            this.cbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltre.FormattingEnabled = true;
            this.cbFiltre.Items.AddRange(new object[] {
            "Tümü",
            "Ana Yemek",
            "İçecek",
            "Tatlı",
            "Soslar"});
            this.cbFiltre.Location = new System.Drawing.Point(628, 10);
            this.cbFiltre.Name = "cbFiltre";
            this.cbFiltre.Size = new System.Drawing.Size(121, 21);
            this.cbFiltre.TabIndex = 6;
            this.cbFiltre.SelectedIndexChanged += new System.EventHandler(this.cbFiltre_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(466, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "MENÜ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(15, 17);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 24);
            this.dtpTarih.TabIndex = 0;
            // 
            // lblCiroSonuc
            // 
            this.lblCiroSonuc.AutoSize = true;
            this.lblCiroSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiroSonuc.Location = new System.Drawing.Point(25, 345);
            this.lblCiroSonuc.Name = "lblCiroSonuc";
            this.lblCiroSonuc.Size = new System.Drawing.Size(335, 37);
            this.lblCiroSonuc.TabIndex = 1;
            this.lblCiroSonuc.Text = "TOPLAM CİRO: 0.00₺";
            // 
            // btnCiroHesapla
            // 
            this.btnCiroHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiroHesapla.Location = new System.Drawing.Point(248, 12);
            this.btnCiroHesapla.Name = "btnCiroHesapla";
            this.btnCiroHesapla.Size = new System.Drawing.Size(120, 35);
            this.btnCiroHesapla.TabIndex = 2;
            this.btnCiroHesapla.Text = "Ciro Hesapla";
            this.btnCiroHesapla.UseVisualStyleBackColor = true;
            this.btnCiroHesapla.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(625, 238);
            this.listBox1.TabIndex = 0;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaEkle.Location = new System.Drawing.Point(6, 297);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(103, 43);
            this.btnMasaEkle.TabIndex = 1;
            this.btnMasaEkle.Text = "Masa Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            // 
            // btnMasaSil
            // 
            this.btnMasaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaSil.Location = new System.Drawing.Point(133, 297);
            this.btnMasaSil.Name = "btnMasaSil";
            this.btnMasaSil.Size = new System.Drawing.Size(103, 43);
            this.btnMasaSil.TabIndex = 1;
            this.btnMasaSil.Text = "Masa Sil";
            this.btnMasaSil.UseVisualStyleBackColor = true;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Ana Yemek",
            "Yan Ürün",
            "İçecek",
            "Tatlı",
            "Sos"});
            this.cbKategori.Location = new System.Drawing.Point(118, 154);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 21);
            this.cbKategori.TabIndex = 6;
            // 
            // dgvCiroDetay
            // 
            this.dgvCiroDetay.AllowUserToAddRows = false;
            this.dgvCiroDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiroDetay.Location = new System.Drawing.Point(6, 71);
            this.dgvCiroDetay.Name = "dgvCiroDetay";
            this.dgvCiroDetay.Size = new System.Drawing.Size(373, 266);
            this.dgvCiroDetay.TabIndex = 3;
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 440);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YoneticiForm";
            this.Text = "YoneticiForm";
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiroDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrunFiyati;
        private System.Windows.Forms.TextBox tbUrunAdi;
        private System.Windows.Forms.ComboBox cbFiltre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnCiroHesapla;
        private System.Windows.Forms.Label lblCiroSonuc;
        private System.Windows.Forms.Button btnMasaSil;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.DataGridView dgvCiroDetay;
    }
}
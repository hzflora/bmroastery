namespace kafeSistemi
{
    partial class Form1
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
            this.flpMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpMasalar
            // 
            this.flpMasalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMasalar.AutoScroll = true;
            this.flpMasalar.Location = new System.Drawing.Point(12, 12);
            this.flpMasalar.Name = "flpMasalar";
            this.flpMasalar.Size = new System.Drawing.Size(496, 273);
            this.flpMasalar.TabIndex = 0;
            // 
            // btnKullanici
            // 
            this.btnKullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanici.Location = new System.Drawing.Point(12, 295);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(160, 38);
            this.btnKullanici.TabIndex = 1;
            this.btnKullanici.Text = "Kullanıcı Değiştir";
            this.btnKullanici.UseVisualStyleBackColor = true;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 341);
            this.Controls.Add(this.btnKullanici);
            this.Controls.Add(this.flpMasalar);
            this.MinimumSize = new System.Drawing.Size(539, 380);
            this.Name = "Form1";
            this.Text = "B&M Roastery - Sipariş Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMasalar;
        private System.Windows.Forms.Button btnKullanici;
    }
}


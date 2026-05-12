namespace kafeSistemi
{
    partial class GirisForm
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
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnGarson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYonetici
            // 
            this.btnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetici.Location = new System.Drawing.Point(12, 107);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(118, 54);
            this.btnYonetici.TabIndex = 0;
            this.btnYonetici.Text = "Yönetici";
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnGarson
            // 
            this.btnGarson.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGarson.Location = new System.Drawing.Point(161, 107);
            this.btnGarson.Name = "btnGarson";
            this.btnGarson.Size = new System.Drawing.Size(118, 54);
            this.btnGarson.TabIndex = 0;
            this.btnGarson.Text = "Garson";
            this.btnGarson.UseVisualStyleBackColor = true;
            this.btnGarson.Click += new System.EventHandler(this.btnGarson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Yöntemini Seçin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGarson);
            this.Controls.Add(this.btnYonetici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GirisForm";
            this.Text = "GirisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnGarson;
        private System.Windows.Forms.Label label1;
    }
}
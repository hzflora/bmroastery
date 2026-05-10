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
            this.btnCiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpMasalar
            // 
            this.flpMasalar.Location = new System.Drawing.Point(12, 12);
            this.flpMasalar.Name = "flpMasalar";
            this.flpMasalar.Size = new System.Drawing.Size(776, 204);
            this.flpMasalar.TabIndex = 0;
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(665, 400);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(123, 38);
            this.btnCiro.TabIndex = 1;
            this.btnCiro.Text = "Günlük Ciro Raporu";
            this.btnCiro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.flpMasalar);
            this.Name = "Form1";
            this.Text = "B&M Roastery - Sipariş Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMasalar;
        private System.Windows.Forms.Button btnCiro;
    }
}


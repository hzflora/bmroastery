using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafeSistemi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiEkrani = new YoneticiForm();

            yoneticiEkrani.FormClosed += (s, args) => Application.Exit();

            yoneticiEkrani.Show();
            this.Hide();
        }

        private void btnGarson_Click(object sender, EventArgs e)
        {
            Form1 garsonEkrani = new Form1();

            // Garson ekranı kapandığında uygulamayı tamamen kapat
            garsonEkrani.FormClosed += (s, args) => Application.Exit();

            garsonEkrani.Show(); // Garson ekranını aç
            this.Hide();
        }
    }
}

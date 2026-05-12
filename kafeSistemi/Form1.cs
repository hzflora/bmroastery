using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MasalariYukle();

        }

        private void MasalariYukle()
        {
            flpMasalar.Controls.Clear(); // Paneli temizle (yenileme yapıldığında üst üste binmesin)

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Tablodaki isimlerin SQL ile birebir aynı (masaID, masaNo vb.) olmasına dikkat et
                    string query = @"
                    SELECT masaID, masaNo, durum 
                    FROM Masalar 
                    ORDER BY 
                        CASE 
                            WHEN masaNo LIKE 'Masa%' THEN 1 
                            WHEN masaNo LIKE 'Bahçe%' THEN 2 
                            ELSE 3 
                        END, 
                        LENGTH(masaNo), 
                        masaNo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int masaID = Convert.ToInt32(reader["masaID"]);
                        string masaNo = reader["masaNo"].ToString();
                        int durum = Convert.ToInt32(reader["durum"]);

                        // Dinamik Buton Oluşturma
                        Button btnMasa = new Button();
                        btnMasa.Text = masaNo;
                        btnMasa.Width = 100;
                        btnMasa.Height = 100;
                        btnMasa.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        btnMasa.Tag = masaID; // Arka planda masanın ID'sini saklıyoruz

                        // Duruma göre renk belirleme (0: Boş, 1: Dolu)
                        if (durum == 0)
                            btnMasa.BackColor = Color.MediumSeaGreen;
                        else
                            btnMasa.BackColor = Color.Tomato;

                        // Butona tıklandığında ne olacağını belirliyoruz
                        btnMasa.Click += Masa_Click;

                        // Oluşturulan butonu FlowLayoutPanel'e ekle
                        flpMasalar.Controls.Add(btnMasa);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                }
            }
        }

        // Dinamik oluşturulan butonların tıklanma olayı
        private void Masa_Click(object sender, EventArgs e)
        {
            Button tiklananMasa = sender as Button;
            int secilenMasaID = Convert.ToInt32(tiklananMasa.Tag);
            string masaAdi = tiklananMasa.Text;
            SiparisForm frmSiparis = new SiparisForm(secilenMasaID, masaAdi);
            frmSiparis.ShowDialog();
            MasalariYukle();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

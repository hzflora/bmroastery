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
using static kafeSistemi.DatabaseHelper;

namespace kafeSistemi
{
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }

        DatabaseHelper dbHelper = new DatabaseHelper();
        int _secilenUrunID = 0;
        private void FormuTemizle()
        {
            tbUrunAdi.Clear();
            tbUrunFiyati.Clear();
            cbKategori.SelectedIndex = -1;
            cbKategori.Text = "";

            _secilenUrunID = 0;
        }
        private void UrunleriGetir()
        {
            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT urunID, ad, fiyat, kategori FROM Urunler order by kategori asc";
                    // MySqlDataAdapter bizim için verileri çeker ve bir tablo formatına dönüştürür
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // dgvUrunler, formdaki DataGridView aracının Name özelliği olmalı.
                    // Eğer sen farklı bir isim verdiysen (örn: dataGridView1), burayı ona göre değiştir.
                    dgvUrunler.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürünleri çekerken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = dtpTarih.Value.Date;

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                // ÖDEV İSTERİ: SQL Join Kullanımı
                // Sipariş edilen ürünleri adetiyle ve o anki fiyatıyla gruplayıp getiriyoruz
                string query = @"
            SELECT 
                u.ad AS 'Ürün Adı', 
                SUM(sd.adet) AS 'Satılan Adet', 
                SUM(sd.adet * sd.birimFiyat) AS 'Elde Edilen Tutar'
            FROM Siparisler s
            JOIN SiparisDetay sd ON s.sipID = sd.sipID
            JOIN Urunler u ON sd.urunID = u.urunID
            WHERE DATE(s.tarih) = @tarih
            GROUP BY u.ad";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // MySQL tarih formatına uygun çeviri yapıyoruz (Yıl-Ay-Gün)
                cmd.Parameters.AddWithValue("@tarih", secilenTarih.ToString("yyyy-MM-dd"));

                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 1. İşlem: DataGridView'i doldur (Hangi üründen ne kadar satılmış göster)
                    dgvCiroDetay.DataSource = dt;

                    // 2. İşlem: DataTable üzerinden genel toplamı hesapla ve Label'a yaz
                    object toplamCiro = dt.Compute("SUM([Elde Edilen Tutar])", "");

                    if (toplamCiro != DBNull.Value && toplamCiro != null)
                    {
                        lblCiroSonuc.Text = $"TOPLAM CİRO: {Convert.ToDecimal(toplamCiro):N2} TL";
                    }
                    else
                    {
                        // O gün hiç satış yapılmadıysa
                        lblCiroSonuc.Text = "TOPLAM CİRO: 0.00 TL";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rapor hesaplanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUrunAdi.Text) ||
            string.IsNullOrWhiteSpace(tbUrunFiyati.Text) ||
            (cbKategori.SelectedItem == null && string.IsNullOrWhiteSpace(cbKategori.Text)))
            {
                MessageBox.Show("Lütfen ürün adını, fiyatını ve kategorisini boş bırakmayın!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi iptal et ve aşağıdaki kodlara geçme
            }

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                string query = "INSERT INTO Urunler (ad, fiyat, kategori) VALUES (@ad, @fiyat, @kat)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", tbUrunAdi.Text);
                cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(tbUrunFiyati.Text));
                string kategoriDegeri = cbKategori.SelectedItem != null ? cbKategori.SelectedItem.ToString() : cbKategori.Text;
                cmd.Parameters.AddWithValue("@kat", kategoriDegeri);

                conn.Open();
                cmd.ExecuteNonQuery();
                UrunleriGetir(); // Tabloyu yenile
                FormuTemizle(); // TextBox'ları boşalt
            }
        }

        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            tabControl1.Size = new Size(830, 388);
            this.Size = new Size(870, 451);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // 1. Sekme: Menü Yönetimi (Büyük Form)
            {
                tabControl1.Size = new Size(830, 388);
                this.Size = new Size(870, 451);
            }
            else if (tabControl1.SelectedIndex == 1) // 2. Sekme: Ciro Raporu (Küçük Form)
            {
                tabControl1.Size = new Size(393, 416);
                this.Size = new Size(433, 479);
            }
            else if (tabControl1.SelectedIndex == 2) // 3. Sekme: Masa Yönetimi
            {
                this.Size = new Size(450, 400);
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUrunler.Rows[e.RowIndex];

                _secilenUrunID = Convert.ToInt32(row.Cells["urunID"].Value);
                tbUrunAdi.Text = row.Cells["ad"].Value.ToString();
                tbUrunFiyati.Text = row.Cells["fiyat"].Value.ToString();
                cbKategori.Text = row.Cells["kategori"].Value.ToString();
            }
        }

        private void cbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenKategori = cbFiltre.SelectedItem.ToString();

            // Varsayılan sorgumuz tüm verileri getirmek üzere kurulu
            string query = "SELECT urunID, ad, fiyat, kategori FROM Urunler";

            // Eğer "Tümü" seçilmediyse sorguya WHERE şartı ekliyoruz
            if (secilenKategori != "Tümü")
            {
                query += " WHERE kategori = @kat";
            }

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (secilenKategori != "Tümü")
                {
                    cmd.Parameters.AddWithValue("@kat", secilenKategori);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenUrunID == 0)
            {
                MessageBox.Show("Lütfen önce tablodan güncellenecek ürünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbUrunAdi.Text) ||
            string.IsNullOrWhiteSpace(tbUrunFiyati.Text) ||
            (cbKategori.SelectedItem == null && string.IsNullOrWhiteSpace(cbKategori.Text)))
            {
                MessageBox.Show("Lütfen ürün adını, fiyatını ve kategorisini boş bırakmayın!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi iptal et ve aşağıdaki kodlara geçme
            }

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                string query = "UPDATE Urunler SET ad=@ad, fiyat=@fiyat, kategori=@kat WHERE urunID=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", tbUrunAdi.Text);
                cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(tbUrunFiyati.Text));
                string kategoriDegeri = cbKategori.SelectedItem != null ? cbKategori.SelectedItem.ToString() : cbKategori.Text;
                cmd.Parameters.AddWithValue("@kat", kategoriDegeri);
                cmd.Parameters.AddWithValue("@id", _secilenUrunID);

                conn.Open();
                cmd.ExecuteNonQuery();
                UrunleriGetir();
                FormuTemizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilenUrunID == 0) return;

            DialogResult cevap = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "DELETE FROM Urunler WHERE urunID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", _secilenUrunID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UrunleriGetir();
                    FormuTemizle();
                }
            }
        }

        private void tbUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
    }
}

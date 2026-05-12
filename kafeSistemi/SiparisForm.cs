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
    public partial class SiparisForm : Form
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        int _masaID; // Hangi masada olduğumuzu bilmemiz lazım
        int _aktifSiparisID = 0; // Masanın açık bir adisyonu var mı?

        // Form1'den masaID'yi buraya parametre olarak alıyoruz
        public SiparisForm(int masaID, string masaNo)
        {
            InitializeComponent();
            _masaID = masaID;
            this.Text = masaNo + " - Sipariş Ekranı";
        }

        private void MevcutSiparisiGetir()
        {
            lstAdisyon.Items.Clear();
            decimal genelToplam = 0;
            _aktifSiparisID = 0; // Her çağrıldığında önce sıfırlıyoruz

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                // 1. Masanın durumunu kontrol et ve aktif bir adisyon numarası (sipID) var mı bul
                // Eğer Masalar tablosunda durum=1 (Dolu) ise, en son açılan sipariş aktiftir.
                string aktifSiparisSorgu = @"
            SELECT s.sipID 
            FROM Siparisler s 
            JOIN Masalar m ON s.masaID = m.masaID 
            WHERE m.masaID = @mID AND m.durum = 1 
            ORDER BY s.sipID DESC LIMIT 1";

                MySqlCommand cmdAktif = new MySqlCommand(aktifSiparisSorgu, conn);
                cmdAktif.Parameters.AddWithValue("@mID", _masaID);

                object result = cmdAktif.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    _aktifSiparisID = Convert.ToInt32(result);
                }

                // 2. Eğer masanın aktif bir siparişi varsa, detaylarını (SQL JOIN) getir
                if (_aktifSiparisID > 0)
                {
                    // SELECT sorgusuna u.urunID eklendi
                    string detaySorgu = @"
                    SELECT u.urunID, u.ad, sd.adet, sd.birimFiyat 
                    FROM SiparisDetay sd
                    JOIN Urunler u ON sd.urunID = u.urunID
                    WHERE sd.sipID = @sipID";

                    MySqlCommand cmdDetay = new MySqlCommand(detaySorgu, conn);
                    cmdDetay.Parameters.AddWithValue("@sipID", _aktifSiparisID);
                    MySqlDataReader reader = cmdDetay.ExecuteReader();

                    while (reader.Read())
                    {
                        int uID = Convert.ToInt32(reader["urunID"]);
                        string urunAd = reader["ad"].ToString();
                        int adet = Convert.ToInt32(reader["adet"]);
                        decimal fiyat = Convert.ToDecimal(reader["birimFiyat"]);
                        decimal satirToplam = adet * fiyat;

                        // Düz metin (string) yerine artık kendi sınıfımızdan bir nesne ekliyoruz
                        lstAdisyon.Items.Add(new AdisyonItem
                        {
                            UrunID = uID,
                            GosterilecekMetin = $"{urunAd} x {adet} = {satirToplam:N2} TL"
                        });

                        genelToplam += satirToplam;
                    }
                    reader.Close();
                }

                // Toplam tutarı ekrana yaz
                lblToplamTutar.Text = $"Toplam: {genelToplam:N2} TL";
            }
        }


        public class UrunItem
        {
            public int UrunID { get; set; }
            public string Ad { get; set; }
            public decimal Fiyat { get; set; }
            public bool IsHeader { get; set; } // Bu yeni eklendi

            public override string ToString()
            {
                // Eğer bu nesne bir başlıksa, fiyat gösterme ve yanlarına tire koy
                if (IsHeader)
                {
                    return $"--- {Ad.ToUpper()} ---";
                }

                // Başlık değilse (normal ürünse) standart şekilde göster
                return $"{Ad} - {Fiyat:N2} TL";
            }
        }

        public class AdisyonItem
        {
            public int UrunID { get; set; }
            public string GosterilecekMetin { get; set; }

            public override string ToString()
            {
                return GosterilecekMetin;
            }
        }
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            MenuyuDoldur();
            MevcutSiparisiGetir(); // Varsa önceki siparişleri listeye çeker
        }

        private void MenuyuDoldur()
        {
            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                // Kategoriyi de çektik ve önce kategoriye, sonra isme göre sıraladık
                string query = "SELECT urunID, ad, fiyat, kategori FROM Urunler ORDER BY kategori, ad";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cbUrunler.Items.Clear();
                    string aktifKategori = ""; // Döngüde kategorinin değişip değişmediğini takip edeceğiz

                    while (reader.Read())
                    {
                        string kategori = reader["kategori"].ToString();

                        // Eğer SQL'den okunan kategori, hafızadaki kategoriden farklıysa araya bir BAŞLIK ekle
                        if (kategori != aktifKategori)
                        {
                            cbUrunler.Items.Add(new UrunItem
                            {
                                UrunID = -1, // Başlıkların ID'si olmaz, -1 verip geçiyoruz
                                Ad = kategori,
                                Fiyat = 0,
                                IsHeader = true
                            });

                            aktifKategori = kategori; // Yeni kategorimizi hafızaya alıyoruz
                        }

                        // Başlığı ekledikten sonra, normal ürünü listeye ekle
                        cbUrunler.Items.Add(new UrunItem
                        {
                            UrunID = Convert.ToInt32(reader["urunID"]),
                            Ad = reader["ad"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["fiyat"]),
                            IsHeader = false
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Menü yüklenirken hata: " + ex.Message);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen eklenecek ürünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UrunItem secilenUrun = (UrunItem)cbUrunler.SelectedItem;
            if (secilenUrun.IsHeader)
            {
                MessageBox.Show("Lütfen bir kategori başlığı değil, eklenecek ürünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ComboBox'tan seçilen nesneyi kendi oluşturduğumuz UrunItem sınıfına çeviriyoruz (Kompozisyon/Kapsülleme)
            int adet = (int)nudAdet.Value;

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                // Senaryo 1: Masa Boştu, İlk Ürün Söylendi (Yeni Adisyon Açılacak)
                if (_aktifSiparisID == 0)
                {
                    // ÖDEV İSTERİ: DateTime Kullanımı
                    string siparisEkleQuery = "INSERT INTO Siparisler (masaID, tarih) VALUES (@mID, @tarih)";
                    MySqlCommand cmdSiparis = new MySqlCommand(siparisEkleQuery, conn);
                    cmdSiparis.Parameters.AddWithValue("@mID", _masaID);
                    cmdSiparis.Parameters.AddWithValue("@tarih", DateTime.Now);
                    cmdSiparis.ExecuteNonQuery();

                    // MySql kütüphanesinin harika bir özelliği: Az önce eklenen satırın ID'sini doğrudan alabiliriz
                    _aktifSiparisID = (int)cmdSiparis.LastInsertedId;

                    // Masanın durumunu Dolu (1) olarak güncelle
                    string masaGuncelleQuery = "UPDATE Masalar SET durum = 1 WHERE masaID = @mID";
                    MySqlCommand cmdMasa = new MySqlCommand(masaGuncelleQuery, conn);
                    cmdMasa.Parameters.AddWithValue("@mID", _masaID);
                    cmdMasa.ExecuteNonQuery();
                }

                // Senaryo 2: Masa Zaten Doluydu veya Yukarıda Yeni Adisyon Açıldı (Ürünü Detaya Ekle)
                string detayEkleQuery = "INSERT INTO SiparisDetay (sipID, urunID, adet, birimFiyat) VALUES (@sipID, @uID, @adet, @fiyat)";
                MySqlCommand cmdDetay = new MySqlCommand(detayEkleQuery, conn);
                cmdDetay.Parameters.AddWithValue("@sipID", _aktifSiparisID);
                cmdDetay.Parameters.AddWithValue("@uID", secilenUrun.UrunID);
                cmdDetay.Parameters.AddWithValue("@adet", adet);
                cmdDetay.Parameters.AddWithValue("@fiyat", secilenUrun.Fiyat); // Fiyatı anlık olarak mühürlüyoruz
                cmdDetay.ExecuteNonQuery();
            }

            // İşlem bitince, adet seçiciyi 1'e geri çek ve listeyi veritabanından güncelleyerek yenile
            nudAdet.Value = 1;
            MevcutSiparisiGetir();
        }

        private void SiparisForm_Load_1(object sender, EventArgs e)
        {
            MenuyuDoldur();
            MevcutSiparisiGetir();
        }

        private void btnHesapOdendi_Click(object sender, EventArgs e)
        {
            if (_aktifSiparisID == 0)
            {
                MessageBox.Show("Bu masada açık bir hesap bulunmuyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Garsonun yanlışlıkla basma ihtimaline karşı bir onay ekranı çıkaralım
            DialogResult onay = MessageBox.Show("Ödeme alınacak ve masa kapatılacak. Onaylıyor musunuz?", "Hesap Kapatma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // 1. İŞLEM: Masayı Boşalt (Durumu 0 yap)
                    string masaGuncelleQuery = "UPDATE Masalar SET durum = 0 WHERE masaID = @mID";
                    MySqlCommand cmdMasa = new MySqlCommand(masaGuncelleQuery, conn);
                    cmdMasa.Parameters.AddWithValue("@mID", _masaID);
                    cmdMasa.ExecuteNonQuery();

                    // 2. İŞLEM: Sipariş tablosundaki 'toplamTutar' sütununu güncelle (Best Practice)
                    // Detaylardaki (adet * fiyat) çarpımının toplamını bulup ana sipariş kaydına yazıyoruz.
                    string tutarGuncelleQuery = @"
                UPDATE Siparisler 
                SET toplamTutar = (SELECT COALESCE(SUM(adet * birimFiyat), 0) FROM SiparisDetay WHERE sipID = @sipID) 
                WHERE sipID = @sipID";
                    MySqlCommand cmdTutar = new MySqlCommand(tutarGuncelleQuery, conn);
                    cmdTutar.Parameters.AddWithValue("@sipID", _aktifSiparisID);
                    cmdTutar.ExecuteNonQuery();
                }

                MessageBox.Show("Ödeme başarıyla alındı. Masa kapatılıyor...", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu kapat. Bu sayede arkada bekleyen Form1'deki kod devam edecek
                // ve masaların rengini yeşile çevirecek!
                this.Close();
            }
        }

        private void lstAdisyon_DoubleClick(object sender, EventArgs e)
        {
            if (lstAdisyon.SelectedItem == null) return;

            // Tıklanan öğeyi AdisyonItem nesnesine çeviriyoruz
            AdisyonItem secilen = (AdisyonItem)lstAdisyon.SelectedItem;

            DialogResult cevap = MessageBox.Show($"Seçilen sipariş: '{secilen.GosterilecekMetin}'\nBunu adisyondan çıkarmak istediğinize emin misiniz?", "Ürün İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    // LIMIT 1 kullanıyoruz: Garson aynı ürünü iki farklı satır olarak girdiyse (örn: önce 1 çay, 5 dk sonra 1 çay daha), sadece birini silsin.
                    string query = "DELETE FROM SiparisDetay WHERE sipID = @sipID AND urunID = @uID LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@sipID", _aktifSiparisID);
                    cmd.Parameters.AddWithValue("@uID", secilen.UrunID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Ürün silindikten sonra listeyi ve toplam fiyatı yeniliyoruz
                MevcutSiparisiGetir();
            }
        }
    }
}

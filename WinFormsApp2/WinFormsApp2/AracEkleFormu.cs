using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class AracEkleFormu : Form
    {
        // Veritabanı bağlantı cümlenizi güncelleyin
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public AracEkleFormu()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text.Trim();

            // Aynı plakayı kontrol et
            if (PlakaKontrolEt(plaka))
            {
                MessageBox.Show("Bu plakaya sahip bir araç zaten mevcut.");
                return;
            }

            // Plaka alanının doldurulup doldurulmadığı kontrolü
            if (string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                MessageBox.Show("Plaka alanı boş bırakılamaz.");
                return;
            }

            // Plaka format kontrolü
            if (!Regex.IsMatch(txtPlaka.Text, @"^\d{2}[A-Z]{1,3}\d{2,4}$"))
            {
                MessageBox.Show("Lütfen geçerli bir plaka formatı girin (örn. 34ABC123).");
                return;
            }

            // Fiyat geçerlilik kontrolü
            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir günlük fiyat girin.");
                return;
            }

            // Araç durumu
            if (cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen aracın durumunu seçin.");
                return;
            }

            // Garanti durumu kontrolü
            if (cmbGarantiDurumu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen aracın garanti durumunu seçin.");
                return;
            }

            // Boş bırakılan alan varsa
            if (cmbUretimYili.SelectedItem == null || cmbAracTipi.SelectedItem == null || cmbYakitTipi.SelectedItem == null || cmbVitesTipi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm seçim alanlarını doldurun.");
                return;
            }

            // Koltuk sayısı
            if (numKoltukSayisi.Value <= 0)
            {
                MessageBox.Show("Koltuk sayısı sıfırdan büyük olmalıdır.");
                return;
            }

            // Kilometre (-) değer alamaz
            if (numKilometre.Value < 0)
            {
                MessageBox.Show("Kilometre bilgisi negatif olamaz.");
                return;
            }

            // SQL bağlantısı ve işlemleri
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // SQL sorgusu (Ekleme)
                    string query = @"INSERT INTO Araclar 
                                     (Plaka, Marka, Model, UretimYili, AracTipi, YakitTipi, VitesTipi, KoltukSayisi, 
                                      Renk, KilometreBilgisi, SonBakimTarihi, SigortaTarihi, GunlukFiyat, Durum, GarantiDurumu) 
                                     VALUES 
                                     (@Plaka, @Marka, @Model, @UretimYili, @AracTipi, @YakitTipi, @VitesTipi, @KoltukSayisi, 
                                      @Renk, @KilometreBilgisi, @SonBakimTarihi, @SigortaTarihi, @GunlukFiyat, @Durum, @GarantiDurumu)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametrelerin atanması
                        command.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                        command.Parameters.AddWithValue("@Marka", txtMarka.Text);
                        command.Parameters.AddWithValue("@Model", txtModel.Text);
                        command.Parameters.AddWithValue("@UretimYili", cmbUretimYili.SelectedItem);
                        command.Parameters.AddWithValue("@AracTipi", cmbAracTipi.SelectedItem);
                        command.Parameters.AddWithValue("@YakitTipi", cmbYakitTipi.SelectedItem);
                        command.Parameters.AddWithValue("@VitesTipi", cmbVitesTipi.SelectedItem);
                        command.Parameters.AddWithValue("@KoltukSayisi", (int)numKoltukSayisi.Value);
                        command.Parameters.AddWithValue("@Renk", txtRenk.Text);
                        command.Parameters.AddWithValue("@KilometreBilgisi", (int)numKilometre.Value);
                        command.Parameters.AddWithValue("@SonBakimTarihi", dtpSonBakim.Value);
                        command.Parameters.AddWithValue("@SigortaTarihi", dtpSigorta.Value);
                        command.Parameters.AddWithValue("@GunlukFiyat", decimal.Parse(txtFiyat.Text));
                        command.Parameters.AddWithValue("@Durum", cmbDurum.SelectedItem);
                        command.Parameters.AddWithValue("@GarantiDurumu", cmbGarantiDurumu.SelectedItem);

                        // Veritabanına bağlantı açma ve komutu çalıştırma
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Araç başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e) // İptal ile anasayfaya dönüş
        {
            // Kullanıcıdan onay almak için mesaj kutusu
            DialogResult result = MessageBox.Show(
                "İşlemi iptal etmek istediğinize emin misiniz?",
                "İptal Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close(); // Formu kapat
            }
        }

        private bool PlakaKontrolEt(string plaka) // Benzersiz plaka kontrol metodu
        {
            // Veritabanında plakayı kontrol et
            string query = "SELECT COUNT(*) FROM Araclar WHERE Plaka = @Plaka";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Plaka", plaka);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Eğer count > 0 ise aynı plakadan var demektir
                }
            }
        }

        private void AracEkleFormu_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp2
{
    public partial class KayitFormu : Form
    {
        
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string sifre = txtKayitSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;

            // Şifre ve şifre tekrar kontrolü
            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifre ve Şifre Tekrar alanları uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemden çık
            }



            // Kayıt işlemi
            KayitOl();
        }

        private void KayitOl()
        {
            string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";
            
            // Kayıt olma işlemi için bilgileri al
            string kullaniciAdi = txtKayitKullaniciAdi.Text;
            string sifre = txtKayitSifre.Text;
            string email = txtKayitEmail.Text;
            string telefon = txtKayitTelefon.Text;
            string dogumTarihi = dtpKayitDogumTarihi.Value.ToString("yyyy-MM-dd"); // DateTimePicker
            string tcKimlikNo = txtKayitTCKimlikNo.Text;
            string ad = txtKayitAd.Text;
            string soyad = txtKayitSoyad.Text;

            // **1. E-Mail Kontrolü**
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi girin!");
                return;
            }
            // **2. Telefon Kontrolü**
            if (!Regex.IsMatch(telefon, @"^\d{10}$"))
            {
                MessageBox.Show("Telefon numarası 10 haneli olmalıdır!");
                return;
            }

            // **3. TC Kimlik Numarası Kontrolü**
            if (tcKimlikNo.Length != 11 || !tcKimlikNo.All(char.IsDigit))
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli ve sadece rakamlardan oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemden çık
            }

            // **4. Diğer Bilgilerin Doğruluğunu Kontrol Etme**
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlemden çık
            }


            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string kontrolQuery = "SELECT COUNT(1) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi";
                    using (SqlCommand kontrolCommand = new SqlCommand(kontrolQuery, connection))
                    {
                        kontrolCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        int varMi = Convert.ToInt32(kontrolCommand.ExecuteScalar());
                        if (varMi > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten alınmış!");
                            return;
                        }
                    }

                    string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Email, Telefon, DogumTarihi, TCKimlikNo, Ad, Soyad) " +
                                   "VALUES (@KullaniciAdi, @Sifre, @Email, @Telefon, @DogumTarihi, @TCKimlikNo, @Ad, @Soyad)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Telefon", telefon);
                        command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                        command.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Kayıt formunu kapat
                        }
                        else
                        {
                            MessageBox.Show("Kayıt başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}

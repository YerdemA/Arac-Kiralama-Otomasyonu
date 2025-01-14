using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class MusteriEkle : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public MusteriEkle()
        {
            InitializeComponent();
        }


        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Alanları kontrol et (boş olup olmadığını)
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtKimlikNo.Text) || string.IsNullOrEmpty(txtTelefonNo.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Kimlik numarasının geçerli olup olmadığını kontrol et
            if (txtKimlikNo.Text.Length != 11 || !txtKimlikNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Geçerli bir kimlik numarası girin (11 haneli).");
                return;
            }

            string telefonRegex = @"^(05\d{9}|05\d{2}-\d{3}-\d{4})$";  // Hem 11 haneli hem de tireli format
            if (!Regex.IsMatch(txtTelefonNo.Text, telefonRegex))
            {
                MessageBox.Show("Geçerli bir telefon numarası girin. Örnek: 05551234567 veya 0555-123-4567");
                return;
            }


            // E-mail'in geçerli formatta olup olmadığını kontrol et
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";  // E-posta formatı
            if (!Regex.IsMatch(txtEmail.Text, emailRegex))
            {
                MessageBox.Show("Geçerli bir e-posta adresi girin.");
                return;
            }

            // Doğum tarihinin geçmiş bir tarih olup olmadığını kontrol et (mantıksal kontrol)
            if (dtpDogumTarihi.Value >= DateTime.Now)
            {
                MessageBox.Show("Geçerli bir doğum tarihi girin.");
                return;
            }

            // Veritabanına müşteri ekleme işlemi
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string kimlikNo = txtKimlikNo.Text;
            string telefonNo = txtTelefonNo.Text;
            string email = txtEmail.Text;
            DateTime dogumTarihi = dtpDogumTarihi.Value;

            // SQL sorgusu
            string query = "INSERT INTO Müşteriler (Ad, Soyad, KimlikNo, TelefonNo, EMail, DogumTarihi) " +
                           "VALUES (@Ad, @Soyad, @KimlikNo, @TelefonNo, @EMail, @DogumTarihi)";

            // Veritabanı bağlantısı
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Parametreler ekleniyor
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@KimlikNo", kimlikNo);
                cmd.Parameters.AddWithValue("@TelefonNo", telefonNo);
                cmd.Parameters.AddWithValue("@EMail", email);
                cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // Başarılı ekleme sonrası mesaj
                    MessageBox.Show("Müşteri başarıyla eklendi.");

                    // Formu temizleyelim
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtKimlikNo.Clear();
                    txtTelefonNo.Clear();
                    txtEmail.Clear();
                    dtpDogumTarihi.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Formdaki tüm giriş alanlarını sıfırla
            txtAd.Clear();
            txtSoyad.Clear();
            txtKimlikNo.Clear();
            txtTelefonNo.Clear();
            txtEmail.Clear();
            dtpDogumTarihi.Value = DateTime.Now; // Tarihi varsayılan olarak bugüne ayarla
        }

    }
}

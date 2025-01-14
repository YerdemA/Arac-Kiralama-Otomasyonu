using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class SifremiUnuttumFormu : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SifremiUnuttumFormu()
        {
            InitializeComponent();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string tcKimlik = txtTcKimlik.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();

            // Girişlerin doğruluğunu kontrol et
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tcKimlik) || string.IsNullOrEmpty(yeniSifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tcKimlik.Length != 11 || !long.TryParse(tcKimlik, out _))
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı doğrulaması
                    string sorgu = @"
                        SELECT COUNT(*) 
                        FROM Kullanicilar
                        WHERE Email = @Email AND TCKimlikNo = @TcKimlik";

                    SqlCommand cmd = new SqlCommand(sorgu, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TcKimlik", tcKimlik);

                    int kullaniciSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                    if (kullaniciSayisi == 1)
                    {
                        // Şifreyi güncelle
                        string guncellemeSorgusu = @"
                            UPDATE Kullanicilar
                            SET Sifre = @YeniSifre
                            WHERE Email = @Email AND TCKimlikNo = @TcKimlik";

                        SqlCommand updateCmd = new SqlCommand(guncellemeSorgusu, connection);
                        updateCmd.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                        updateCmd.Parameters.AddWithValue("@Email", email);
                        updateCmd.Parameters.AddWithValue("@TcKimlik", tcKimlik);

                        int sonuc = updateCmd.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Şifre başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEmail.Clear();
                            txtTcKimlik.Clear();
                            txtYeniSifre.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Şifre güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen bilgilerle eşleşen bir kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // SQL Server ba�lant� dizesi
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kullan�c� bilgilerini ve checkbox durumunu otomatik doldur
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\AracKiralamaApp");
            if (key != null)
            {
                txtKullaniciAdi.Text = key.GetValue("KullaniciAdi", "").ToString();
                txtSifre.Text = key.GetValue("Sifre", "").ToString();

                // Checkbox durumu
                chkBeniHatirla.Checked = key.GetValue("BeniHatirla", "False").ToString() == "True";

                key.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkBeniHatirla.Checked)
            {
                // Kullan�c� bilgileri kaydediliyor
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\AracKiralamaApp");
                key.SetValue("KullaniciAdi", txtKullaniciAdi.Text);
                key.SetValue("Sifre", txtSifre.Text);
                key.SetValue("BeniHatirla", "True");
                key.Close();
            }
            else
            {
                // Kaydedilen kullan�c� bilgileri temizleniyor
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\AracKiralamaApp");
                key.DeleteValue("KullaniciAdi", false);
                key.DeleteValue("Sifre", false);
                key.SetValue("BeniHatirla", "False");
                key.Close();
            }

            // Kullan�c� giri� bilgilerini al�yoruz
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // SQL ba�lant�s�n� a��yoruz
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kullan�c� ad� ve �ifre kontrol� i�in SQL sorgusu
                    string query = "SELECT COUNT(1) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekliyoruz
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        // Sorguyu �al��t�r�p sonucu al�yoruz
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Giri� ba�ar�l�!");
                            AnaSayfa anaSayfa = new AnaSayfa();
                            anaSayfa.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ba�lant� hatas�: " + ex.Message);
                }
            }
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Kay�t formunu olu�tur ve g�ster
            KayitFormu kayitFormu = new KayitFormu();

            // Kay�t formu kapand���nda login formunu tekrar g�ster
            kayitFormu.FormClosed += (s, args) => this.Show();

            kayitFormu.Show();

            // Login sayfas�n� gizle
            this.Hide();
        }

        private void btnSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttumFormu sifremiUnuttumFormu = new SifremiUnuttumFormu();
            sifremiUnuttumFormu.ShowDialog();
        }
    }
}
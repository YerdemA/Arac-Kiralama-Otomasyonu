using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // SQL Server baðlantý dizesi
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kullanýcý bilgilerini ve checkbox durumunu otomatik doldur
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
                // Kullanýcý bilgileri kaydediliyor
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\AracKiralamaApp");
                key.SetValue("KullaniciAdi", txtKullaniciAdi.Text);
                key.SetValue("Sifre", txtSifre.Text);
                key.SetValue("BeniHatirla", "True");
                key.Close();
            }
            else
            {
                // Kaydedilen kullanýcý bilgileri temizleniyor
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\AracKiralamaApp");
                key.DeleteValue("KullaniciAdi", false);
                key.DeleteValue("Sifre", false);
                key.SetValue("BeniHatirla", "False");
                key.Close();
            }

            // Kullanýcý giriþ bilgilerini alýyoruz
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // SQL baðlantýsýný açýyoruz
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kullanýcý adý ve þifre kontrolü için SQL sorgusu
                    string query = "SELECT COUNT(1) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekliyoruz
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        // Sorguyu çalýþtýrýp sonucu alýyoruz
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Giriþ baþarýlý!");
                            AnaSayfa anaSayfa = new AnaSayfa();
                            anaSayfa.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Baðlantý hatasý: " + ex.Message);
                }
            }
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Kayýt formunu oluþtur ve göster
            KayitFormu kayitFormu = new KayitFormu();

            // Kayýt formu kapandýðýnda login formunu tekrar göster
            kayitFormu.FormClosed += (s, args) => this.Show();

            kayitFormu.Show();

            // Login sayfasýný gizle
            this.Hide();
        }

        private void btnSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttumFormu sifremiUnuttumFormu = new SifremiUnuttumFormu();
            sifremiUnuttumFormu.ShowDialog();
        }
    }
}
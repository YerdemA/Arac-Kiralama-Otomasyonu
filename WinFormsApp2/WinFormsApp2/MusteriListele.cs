using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class MusteriListele : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        Dictionary<string, string> aramaKolonlari;

        public MusteriListele()
        {
            InitializeComponent();
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            // Arama kolonlarını doldur
            aramaKolonlari = new Dictionary<string, string>
            {
                { "Ad", "Ad" },
                { "Soyad", "Soyad" },
                { "Tc Kimlik Numarası", "KimlikNo" },
                { "Telefon Numarası", "TelefonNo" },
                { "E-Mail", "EMail" },
                { "Doğum Tarihi", "DogumTarihi" }
            };

            cmbAramaKolonu.DataSource = new BindingSource(aramaKolonlari, null);
            cmbAramaKolonu.DisplayMember = "Key";
            cmbAramaKolonu.ValueMember = "Value";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string siralama = "";

            // Sıralama seçeneklerini kontrol et
            if (rdIdK_B.Checked)
            {
                siralama = "ASC"; // Küçükten büyüğe
            }
            else if (rdIdB_K.Checked)
            {
                siralama = "DESC"; // Büyükten küçüğe
            }
            else
            {
                MessageBox.Show("Lütfen bir sıralama seçeneği belirleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sadece aktif müşterileri getiren sorgu
            string sorgu = $"SELECT * FROM Müşteriler WHERE Durum = 'Aktif' ORDER BY MüşteriID {siralama}";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    baglanti.Open();
                    da.Fill(dt);
                    dgvMusteriler.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string seciliKolon = ((KeyValuePair<string, string>)cmbAramaKolonu.SelectedItem).Value;

            // Eğer DogumTarihi seçildiyse özel bir tarih formatı kontrolü yapılabilir
            if (seciliKolon == "DogumTarihi" && !string.IsNullOrWhiteSpace(txtArama.Text))
            {
                if (!Regex.IsMatch(txtArama.Text, "^\\d{4}-\\d{2}-\\d{2}$"))
                {
                    lblTarihUyarisi.Visible = true;
                }
                else
                {
                    lblTarihUyarisi.Visible = false;
                }
            }
            else
            {
                lblTarihUyarisi.Visible = false;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    string sorgu = $"SELECT * FROM Müşteriler WHERE {seciliKolon} LIKE @arama";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@arama", $"%{txtArama.Text}%");

                    DataTable dt = new DataTable();
                    baglanti.Open();
                    da.Fill(dt);
                    dgvMusteriler.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAramaKolonu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliKolon = ((KeyValuePair<string, string>)cmbAramaKolonu.SelectedItem).Value;

            // Eğer seçili kolon DogumTarihi ise lblTarihUyarisi görünür olur
            if (seciliKolon == "DogumTarihi")
            {
                lblTarihUyarisi.Visible = true;
            }
            else
            {
                lblTarihUyarisi.Visible = false;
            }
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace WinFormsApp2
{
    public partial class AracListele : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Kullanıcı dostu sütun adlarını veritabanı sütun adlarıyla eşleştiren sözlük
        Dictionary<string, string> columnMappings = new Dictionary<string, string>()
        {
            { "Plaka", "Plaka" },
            { "Marka", "Marka" },
            { "Model", "Model" },
            { "Durum", "Durum" },
            { "Günlük Fiyat", "GunlukFiyat" },
            { "Üretim Yılı", "UretimYili" },
            { "Araç Tipi", "AraçTipi" },
            { "Yakıt Tipi", "YakitTipi" },
            { "Vites Tipi", "VitesTipi" },
            { "Koltuk Sayısı", "KoltukSayisi" },
            { "Renk", "Renk" },
            { "Kilometre Bilgisi", "KilometreBilgisi" },
            { "Son Bakım Tarihi", "SonBakimTarihi" },
            { "Garanti Durumu", "GarantiDurumu" },
            { "Kiralama Sayısı", "KiralamaSayisi" },
            { "Sigorta Tarihi", "SigortaTarihi" }
        };

        public AracListele()
        {
            InitializeComponent();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            // ComboBox'a kullanıcı dostu sütun adlarını ekle
            cmbAramaKolonu.Items.AddRange(columnMappings.Keys.ToArray());

            // Varsayılan olarak tüm araçları listele
            AraclariGetir();
        }

        private void AraclariGetir(string aramaKolonu = null, string aramaTerimi = null, string siralamaKriteri = null)
        {
            string query = "SELECT * FROM Araclar WHERE VarlikDurumu = 'Aktif'"; // Sadece aktif araçları al

            // Dinamik filtreleme
            if (!string.IsNullOrEmpty(aramaKolonu) && !string.IsNullOrEmpty(aramaTerimi))
            {
                query += $" AND {aramaKolonu} LIKE @AramaTerimi"; // Filtreyi aktif araçlarla birleştir
            }

            // Dinamik sıralama
            if (!string.IsNullOrEmpty(siralamaKriteri))
            {
                query += $" {siralamaKriteri}";
            }

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(aramaKolonu) && !string.IsNullOrEmpty(aramaTerimi))
                        {
                            command.Parameters.AddWithValue("@AramaTerimi", $"%{aramaTerimi}%");
                        }

                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }

                    // DataGridView'e veri yükleme
                    dgvAraclar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void btnListele_Click(object sender, EventArgs e)
        {
            string siralamaKriteri = "";

            // Fiyat sıralama kriterini kontrol et
            if (rbFiyatD_Y.Checked)
            {
                siralamaKriteri = "ORDER BY GunlukFiyat ASC"; // Fiyata göre düşükten yükseğe
            }
            else if (rbFiyatY_D.Checked)
            {
                siralamaKriteri = "ORDER BY GunlukFiyat DESC"; // Fiyata göre yüksekten düşüğe
            }

            // Kilometre sıralama kriterini kontrol et
            else if (rbKilometreD_Y.Checked)
            {
                siralamaKriteri = "ORDER BY KilometreBilgisi ASC"; // Kilometreye göre düşükten yükseğe
            }
            else if (rbKilometreY_D.Checked)
            {
                siralamaKriteri = "ORDER BY KilometreBilgisi DESC"; // Kilometreye göre yüksekten düşüğe
            }

            // Kullanıcı dostu sütun adı seçimi
            string aramaKolonuSecimi = cmbAramaKolonu.SelectedItem?.ToString();
            string aramaKolonu = null;
            if (!string.IsNullOrEmpty(aramaKolonuSecimi) && columnMappings.ContainsKey(aramaKolonuSecimi))
            {
                aramaKolonu = columnMappings[aramaKolonuSecimi];
            }

            string aramaTerimi = txtArama.Text.Trim();

            // Araçları listele
            AraclariGetir(aramaKolonu, aramaTerimi, siralamaKriteri);
        }


        private void txtArama_KeyUp(object sender, KeyEventArgs e)
        {
            // Anlık arama işlemi
            string aramaKolonuSecimi = cmbAramaKolonu.SelectedItem?.ToString();
            string aramaKolonu = null;

            if (!string.IsNullOrEmpty(aramaKolonuSecimi) && columnMappings.ContainsKey(aramaKolonuSecimi))
            {
                aramaKolonu = columnMappings[aramaKolonuSecimi];
            }

            string aramaTerimi = txtArama.Text.Trim();
            AraclariGetir(aramaKolonu, aramaTerimi);
        }

        // Sigorta tarihi veya Son bakım tarihi seçildiğinde gözükecek  uyarı.
        private void cmbAramaKolonu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAramaKolonu.SelectedItem.ToString() == "Sigorta Tarihi" || cmbAramaKolonu.SelectedItem.ToString() == "Son Bakım Tarihi")
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

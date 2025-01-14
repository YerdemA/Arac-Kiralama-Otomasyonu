using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class AracSilFormu : Form
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

        public AracSilFormu()
        {
            InitializeComponent();
        }

        private void AracSilFormu_Load(object sender, EventArgs e)
        {
            // ComboBox'a kullanıcı dostu sütun adlarını ekle
            cmbAramaKolonu.Items.AddRange(columnMappings.Keys.ToArray());

            // Varsayılan olarak aktif araçları listele
            ListeleAraclar();
        }

        private void ListeleAraclar(string aramaKolonu = null, string aramaTerimi = null)
        {
            string query = "SELECT AracID, Plaka, Marka, Model, Durum, GunlukFiyat FROM Araclar WHERE VarlikDurumu = 'Aktif'";

            // Dinamik filtreleme
            if (!string.IsNullOrEmpty(aramaKolonu) && !string.IsNullOrEmpty(aramaTerimi))
            {
                query += $" AND {aramaKolonu} LIKE @AramaTerimi";
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
            ListeleAraclar(aramaKolonu, aramaTerimi);
        }

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir araç seçin.");
                return;
            }

            var secilenAracId = dgvAraclar.SelectedRows[0].Cells["AracID"].Value;
            if (secilenAracId == null)
            {
                MessageBox.Show("Geçersiz araç seçimi.");
                return;
            }

            string secilenPlaka = dgvAraclar.SelectedRows[0].Cells["Plaka"].Value.ToString();

            DialogResult onay = MessageBox.Show(
                $"{secilenPlaka} plakalı aracı silmek istediğinizden emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                AracSil(secilenPlaka);
            }
        }

        private void AracSil(string plaka)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                // Silme işlemi yerine VarlikDurumu'nu "Silinmiş" olarak güncelleme
                string sorgu = "UPDATE Araclar SET VarlikDurumu = 'Silinmiş' WHERE Plaka = @Plaka";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Plaka", plaka);

                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Araç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeleAraclar(); // Listeyi güncelle
                }
                else
                {
                    MessageBox.Show("Araç silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

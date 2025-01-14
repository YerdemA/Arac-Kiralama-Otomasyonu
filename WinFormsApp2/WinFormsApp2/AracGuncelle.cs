using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class AracGuncelle : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        Dictionary<string, string> sutunIsimleri = new Dictionary<string, string>
        {
            { "Plaka", "Plaka" },
            { "Marka", "Marka" },
            { "Model", "Model" },
            { "Renk", "Renk" },
            { "GunlukFiyat", "Günlük Fiyat" },
            { "UretimYili", "Üretim Yılı" },
            { "AracTipi", "Araç Tipi" },
            { "YakitTipi", "Yakıt Tipi" },
            { "VitesTipi", "Vites Tipi" },
            { "Durum", "Durum" },
            { "KoltukSayisi", "Koltuk Sayısı" },
            { "KilometreBilgisi", "Kilometre" },
            { "SonBakimTarihi", "Son Bakım Tarihi" },
            { "SigortaTarihi", "Sigorta Tarihi" }
        };

        public AracGuncelle()
        {
            InitializeComponent();
        }

        private void AracGuncelle_Load(object sender, EventArgs e)
        {
            cmbAramaKolonu.DataSource = new BindingSource(sutunIsimleri, null);
            cmbAramaKolonu.DisplayMember = "Value";
            cmbAramaKolonu.ValueMember = "Key";
            ListeleAraclar();
        }

        private void ListeleAraclar()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                // VarlikDurumu 'Aktif' olan araçları listelemek için sorgu
                string sorgu = "SELECT * FROM Araclar WHERE VarlikDurumu = 'Aktif'";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dgvAraclar.DataSource = tablo;
            }
        }


        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (cmbAramaKolonu.SelectedItem == null || string.IsNullOrWhiteSpace(txtArama.Text)) return;

            string secilenKolon = ((KeyValuePair<string, string>)cmbAramaKolonu.SelectedItem).Key;
            string aramaMetni = txtArama.Text;

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string sorgu = $"SELECT * FROM Araclar WHERE {secilenKolon} LIKE @aramaMetni";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                adapter.SelectCommand.Parameters.AddWithValue("@aramaMetni", $"%{aramaMetni}%");

                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dgvAraclar.DataSource = tablo;
            }
        }

        private void cmbAramaKolonu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAramaKolonu.SelectedItem != null)
            {
                string secilenKolon = ((KeyValuePair<string, string>)cmbAramaKolonu.SelectedItem).Key;
                lblTarihUyarisi.Visible = (secilenKolon == "SonBakimTarihi" || secilenKolon == "SigortaTarihi");
            }
        }

        private void dgvAraclar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow satir = dgvAraclar.SelectedRows[0];
                    txtPlaka.Text = satir.Cells["Plaka"].Value?.ToString() ?? string.Empty;
                    txtMarka.Text = satir.Cells["Marka"].Value?.ToString() ?? string.Empty;
                    txtModel.Text = satir.Cells["Model"].Value?.ToString() ?? string.Empty;
                    txtRenk.Text = satir.Cells["Renk"].Value?.ToString() ?? string.Empty;
                    txtGunlukFiyat.Text = satir.Cells["GunlukFiyat"].Value?.ToString() ?? string.Empty;
                    cmbUretimYili.Text = satir.Cells["UretimYili"].Value?.ToString() ?? string.Empty;
                    cmbAracTipi.Text = satir.Cells["AracTipi"].Value?.ToString() ?? string.Empty;
                    cmbYakitTipi.Text = satir.Cells["YakitTipi"].Value?.ToString() ?? string.Empty;
                    cmbVitesTipi.Text = satir.Cells["VitesTipi"].Value?.ToString() ?? string.Empty;
                    cmbDurum.Text = satir.Cells["Durum"].Value?.ToString() ?? string.Empty;
                    cmbGarantiDurumu.Text = satir.Cells["GarantiDurumu"].Value?.ToString() ?? string.Empty;
                    numKoltukSayisi.Value = Convert.ToDecimal(satir.Cells["KoltukSayisi"].Value ?? 0);
                    numKilometre.Value = Convert.ToDecimal(satir.Cells["KilometreBilgisi"].Value ?? 0);
                    dtpSonBakim.Value = Convert.ToDateTime(satir.Cells["SonBakimTarihi"].Value ?? DateTime.Now);
                    dtpSigortaTarihi.Value = Convert.ToDateTime(satir.Cells["SigortaTarihi"].Value ?? DateTime.Now);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            girisPaneliniTemizle();
        }

        private void girisPaneliniTemizle()
        {
            txtPlaka.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtRenk.Clear();
            txtGunlukFiyat.Clear();
            cmbUretimYili.SelectedIndex = -1;
            cmbAracTipi.SelectedIndex = -1;
            cmbYakitTipi.SelectedIndex = -1;
            cmbVitesTipi.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;
            cmbGarantiDurumu.SelectedIndex = -1;
            numKoltukSayisi.Value = 1;
            numKilometre.Value = 0;
            dtpSonBakim.Value = DateTime.Now;
            dtpSigortaTarihi.Value = DateTime.Now;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count > 0)
            {
                int aracId = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells["AracID"].Value);

                // Alanların doluluğunu kontrol et
                if (string.IsNullOrWhiteSpace(txtPlaka.Text))
                {
                    MessageBox.Show("Plaka alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMarka.Text))
                {
                    MessageBox.Show("Marka alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    MessageBox.Show("Model alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtRenk.Text))
                {
                    MessageBox.Show("Renk alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbUretimYili.SelectedItem == null)
                {
                    MessageBox.Show("Üretim Yılı seçilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbAracTipi.SelectedItem == null)
                {
                    MessageBox.Show("Araç Tipi seçilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbYakitTipi.SelectedItem == null)
                {
                    MessageBox.Show("Yakıt Tipi seçilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbVitesTipi.SelectedItem == null)
                {
                    MessageBox.Show("Vites Tipi seçilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbGarantiDurumu.SelectedItem == null)
                {
                    MessageBox.Show("Garanti Durumu seçilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbDurum.SelectedItem == null)
                {
                    MessageBox.Show("Durum seçilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtGunlukFiyat.Text, out decimal gunlukFiyat) || gunlukFiyat <= 0)
                {
                    MessageBox.Show("Geçerli bir Günlük Fiyat girilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Plaka kontrolü
                string plaka = txtPlaka.Text;
                if (!System.Text.RegularExpressions.Regex.IsMatch(plaka, @"^\d{2}[A-Z]{1,3}\d{1,4}$"))
                {
                    MessageBox.Show("Lütfen geçerli bir plaka girin. Örnek: 34ABC123", "Hatalı Plaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Diğer alanların alınması
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                string renk = txtRenk.Text;
                string uretimYili = cmbUretimYili.SelectedItem.ToString();
                string aracTipi = cmbAracTipi.SelectedItem.ToString();
                string yakitTipi = cmbYakitTipi.SelectedItem.ToString();
                string vitesTipi = cmbVitesTipi.SelectedItem.ToString();
                string garantiDurumu = cmbGarantiDurumu.SelectedItem.ToString();
                int koltukSayisi = (int)numKoltukSayisi.Value;
                int kilometre = (int)numKilometre.Value;
                DateTime? sonBakim = dtpSonBakim.Checked ? dtpSonBakim.Value : (DateTime?)null;
                DateTime? sigortaTarihi = dtpSigortaTarihi.Checked ? dtpSigortaTarihi.Value : (DateTime?)null;
                string durum = cmbDurum.SelectedItem.ToString();

                List<string> setClauses = new List<string>
        {
            "Plaka = @Plaka",
            "Marka = @Marka",
            "Model = @Model",
            "Renk = @Renk",
            "UretimYili = @UretimYili",
            "AracTipi = @AracTipi",
            "YakitTipi = @YakitTipi",
            "VitesTipi = @VitesTipi",
            "GarantiDurumu = @GarantiDurumu",
            "KoltukSayisi = @KoltukSayisi",
            "KilometreBilgisi = @Kilometre",
            "GunlukFiyat = @GunlukFiyat",
            "Durum = @Durum"
        };
                if (sonBakim.HasValue) setClauses.Add("SonBakimTarihi = @SonBakimTarihi");
                if (sigortaTarihi.HasValue) setClauses.Add("SigortaTarihi = @SigortaTarihi");

                string sorgu = $"UPDATE Araclar SET {string.Join(", ", setClauses)} WHERE AracID = @AracID";

                try
                {
                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@AracID", aracId);
                        komut.Parameters.AddWithValue("@Plaka", plaka);
                        komut.Parameters.AddWithValue("@Marka", marka);
                        komut.Parameters.AddWithValue("@Model", model);
                        komut.Parameters.AddWithValue("@Renk", renk);
                        komut.Parameters.AddWithValue("@UretimYili", uretimYili);
                        komut.Parameters.AddWithValue("@AracTipi", aracTipi);
                        komut.Parameters.AddWithValue("@YakitTipi", yakitTipi);
                        komut.Parameters.AddWithValue("@VitesTipi", vitesTipi);
                        komut.Parameters.AddWithValue("@GarantiDurumu", garantiDurumu);
                        komut.Parameters.AddWithValue("@KoltukSayisi", koltukSayisi);
                        komut.Parameters.AddWithValue("@Kilometre", kilometre);
                        komut.Parameters.AddWithValue("@GunlukFiyat", gunlukFiyat);
                        komut.Parameters.AddWithValue("@Durum", durum);
                        if (sonBakim.HasValue) komut.Parameters.AddWithValue("@SonBakimTarihi", sonBakim.Value);
                        if (sigortaTarihi.HasValue) komut.Parameters.AddWithValue("@SigortaTarihi", sigortaTarihi.Value);

                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();
                        baglanti.Close();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Araç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListeleAraclar();
                            girisPaneliniTemizle();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

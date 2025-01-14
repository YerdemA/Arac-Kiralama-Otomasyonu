using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class MuhasebeFormu : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private DataTable orijinalVeriTablosu; // Orijinal tabloyu saklamak için

        public MuhasebeFormu()
        {
            InitializeComponent();
        }

        private void MuhasebeFormu_Load(object sender, EventArgs e)
        {
            cmbFiltre.Items.AddRange(new string[] { "Hepsi", "Gelir", "Gider" });
            cmbFiltre.SelectedIndex = 0;
            Listele();

            // RadioButton olaylarını bağla
            rbTutarD_Y.CheckedChanged += RadioButton_CheckedChanged;
            rbTutarY_D.CheckedChanged += RadioButton_CheckedChanged;
            rbTarihE_Y.CheckedChanged += RadioButton_CheckedChanged;
            rbTarihY_E.CheckedChanged += RadioButton_CheckedChanged;
            rbStandart.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void Listele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    string sorgu = @"
                        SELECT 'Gelir' AS Tür, Tarih, Aciklama, Tutar 
                        FROM Gelir
                        UNION ALL
                        SELECT 'Gider' AS Tür, Tarih, Aciklama, Tutar 
                        FROM Gider
                        ORDER BY Tarih ASC";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    orijinalVeriTablosu = new DataTable();
                    da.Fill(orijinalVeriTablosu);

                    // İlk listeleme için orijinal tabloyu bağla
                    dgvMuhasebe.DataSource = orijinalVeriTablosu;

                    Hesapla(orijinalVeriTablosu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hesapla(DataTable dt)
        {
            var toplamGelir = dt.AsEnumerable()
                .Where(row => row["Tür"].ToString() == "Gelir")
                .Sum(row => Convert.ToDecimal(row["Tutar"]));

            var toplamGider = dt.AsEnumerable()
                .Where(row => row["Tür"].ToString() == "Gider")
                .Sum(row => Convert.ToDecimal(row["Tutar"]));

            var netKar = toplamGelir - toplamGider;

            lblToplamGelir.Text = $"Toplam Gelir: {toplamGelir:C}";
            lblToplamGider.Text = $"Toplam Gider: {toplamGider:C}";
            lblNetKar.Text = $"Net Kar: {netKar:C}";
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                var filtre = cmbFiltre.SelectedItem.ToString();
                var baslangicTarihi = dtpBaslangicTarihi.Value.Date;
                var bitisTarihi = dtpBitisTarihi.Value.Date;

                var filtreliVeriler = orijinalVeriTablosu.AsEnumerable()
                    .Where(row =>
                    {
                        var tarih = Convert.ToDateTime(row["Tarih"]);
                        var tur = row["Tür"].ToString();
                        return tarih >= baslangicTarihi && tarih <= bitisTarihi &&
                               (filtre == "Hepsi" || tur == filtre);
                    });

                if (!filtreliVeriler.Any())
                {
                    MessageBox.Show("Filtreleme sonucu gösterilecek veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable filtreliTablo = filtreliVeriler.CopyToDataTable();
                dgvMuhasebe.DataSource = filtreliTablo;

                Hesapla(filtreliTablo);
            }
            catch (Exception)
            {
                MessageBox.Show("Filtreleme sonucu gösterilecek veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            cmbFiltre.SelectedIndex = 0;
            dtpBaslangicTarihi.Value = DateTime.Now.AddMonths(-1);
            dtpBitisTarihi.Value = DateTime.Now;

            dgvMuhasebe.DataSource = orijinalVeriTablosu;
            Hesapla(orijinalVeriTablosu);
        }

        private void ApplySorting()
        {
            if (dgvMuhasebe.DataSource is DataTable currentTable)
            {
                DataView view = currentTable.DefaultView;

                if (rbTutarD_Y.Checked)
                {
                    view.Sort = "Tutar ASC"; // Tutarı düşükten yükseğe sırala
                }
                else if (rbTutarY_D.Checked)
                {
                    view.Sort = "Tutar DESC"; // Tutarı yüksekten düşüğe sırala
                }
                else if (rbTarihE_Y.Checked)
                {
                    view.Sort = "Tarih ASC"; // Tarihi eskiden yeniye sırala
                }
                else if (rbTarihY_E.Checked)
                {
                    view.Sort = "Tarih DESC"; // Tarihi yeniden eskiye sırala
                }
                else if (rbStandart.Checked)
                {
                    view.Sort = ""; // Varsayılan sıralama
                }

                dgvMuhasebe.DataSource = view.ToTable(); // Sıralanmış tabloyu tekrar ata
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ApplySorting();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Girişleri Kontrol Et
                if (string.IsNullOrWhiteSpace(txtTutar.Text) || !decimal.TryParse(txtTutar.Text, out decimal yeniTutar) || yeniTutar <= 0)
                {
                    MessageBox.Show("Geçerli bir Tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAciklama.Text))
                {
                    MessageBox.Show("Açıklama boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!DateTime.TryParse(mtxtTarih.Text, out DateTime yeniTarih))
                {
                    MessageBox.Show("Geçerli bir Tarih giriniz (YYYY-AA-GG).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbTur.SelectedItem == null || (cmbTur.SelectedItem.ToString() != "Gelir" && cmbTur.SelectedItem.ToString() != "Gider"))
                {
                    MessageBox.Show("Lütfen Gelir veya Gider türünü seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Tablo Seçimi
                string yeniTablo = cmbTur.SelectedItem.ToString() == "Gelir" ? "Gelir" : "Gider";

                // 3. Güncellenecek Satırı Bul
                if (dgvMuhasebe.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Lütfen güncellemek için bir satır seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow seciliSatir = dgvMuhasebe.SelectedRows[0];
                string eskiTur = seciliSatir.Cells["Tür"].Value.ToString();
                DateTime eskiTarih = Convert.ToDateTime(seciliSatir.Cells["Tarih"].Value);
                string eskiAciklama = seciliSatir.Cells["Aciklama"].Value.ToString();
                decimal eskiTutar = Convert.ToDecimal(seciliSatir.Cells["Tutar"].Value);

                // 4. Tür Değişimi Gerekiyor mu?
                if (eskiTur != yeniTablo)
                {
                    // Farklı tabloya taşınması gerekiyor
                    string silmeSorgusu = $@"
                DELETE FROM {eskiTur}
                WHERE Tarih = @EskiTarih AND Aciklama = @EskiAciklama AND Tutar = @EskiTutar";

                    string eklemeSorgusu = $@"
                INSERT INTO {yeniTablo} (Tarih, Aciklama, Tutar)
                VALUES (@YeniTarih, @YeniAciklama, @YeniTutar)";

                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        baglanti.Open();
                        SqlTransaction transaction = baglanti.BeginTransaction();

                        try
                        {
                            // Eski tablodan sil
                            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti, transaction);
                            silKomutu.Parameters.AddWithValue("@EskiTarih", eskiTarih);
                            silKomutu.Parameters.AddWithValue("@EskiAciklama", eskiAciklama);
                            silKomutu.Parameters.AddWithValue("@EskiTutar", eskiTutar);
                            silKomutu.ExecuteNonQuery();

                            // Yeni tabloya ekle
                            SqlCommand ekleKomutu = new SqlCommand(eklemeSorgusu, baglanti, transaction);
                            ekleKomutu.Parameters.AddWithValue("@YeniTarih", yeniTarih);
                            ekleKomutu.Parameters.AddWithValue("@YeniAciklama", txtAciklama.Text);
                            ekleKomutu.Parameters.AddWithValue("@YeniTutar", yeniTutar);
                            ekleKomutu.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception($"Güncelleme işlemi başarısız oldu: {ex.Message}");
                        }
                    }
                }
                else
                {
                    // Tür değişimi gerekmiyor, sadece mevcut kaydı güncelle
                    string sorgu = $@"
                UPDATE {yeniTablo}
                SET Tarih = @YeniTarih, Aciklama = @YeniAciklama, Tutar = @YeniTutar
                WHERE Tarih = @EskiTarih AND Aciklama = @EskiAciklama AND Tutar = @EskiTutar";

                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@YeniTarih", yeniTarih);
                        komut.Parameters.AddWithValue("@YeniAciklama", txtAciklama.Text);
                        komut.Parameters.AddWithValue("@YeniTutar", yeniTutar);
                        komut.Parameters.AddWithValue("@EskiTarih", eskiTarih);
                        komut.Parameters.AddWithValue("@EskiAciklama", eskiAciklama);
                        komut.Parameters.AddWithValue("@EskiTutar", eskiTutar);

                        int etkilenenKayit = komut.ExecuteNonQuery();
                        if (etkilenenKayit > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız oldu. Kaydı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // 5. Listeyi Yenile ve Girişleri Temizle
                Listele();
                PanelTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMuhasebe.SelectedRows.Count > 0)
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();

                    foreach (DataGridViewRow selectedRow in dgvMuhasebe.SelectedRows)
                    {
                        var tur = selectedRow.Cells["Tür"].Value.ToString();
                        var tarih = Convert.ToDateTime(selectedRow.Cells["Tarih"].Value);
                        var tutar = Convert.ToDecimal(selectedRow.Cells["Tutar"].Value);

                        string sorgu = tur == "Gelir"
                            ? "DELETE FROM Gelir WHERE Tarih = @Tarih AND Tutar = @Tutar"
                            : "DELETE FROM Gider WHERE Tarih = @Tarih AND Tutar = @Tutar";

                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@Tarih", tarih);
                        komut.Parameters.AddWithValue("@Tutar", tutar);

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Seçili kayıtlar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir veya daha fazla satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PanelTemizle()
        {
            txtTutar.Clear();
            txtAciklama.Clear();
            mtxtTarih.Clear();
            cmbTur.SelectedIndex = -1; // Seçimi temizler
        }

        private void cbFiltrePaneli_CheckedChanged(object sender, EventArgs e)
        {
            pnlFiltre.Visible = cbFiltrePaneli.Checked;
        }

        private void cbGuncellePaneli_CheckedChanged(object sender, EventArgs e)
        {
            pnlGuncelle.Visible = cbGuncellePaneli.Checked;
        }
    }
}

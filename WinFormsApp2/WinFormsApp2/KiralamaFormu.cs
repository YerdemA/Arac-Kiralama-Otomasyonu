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
    public partial class KiralamaFormu : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public KiralamaFormu()
        {
            InitializeComponent();
        }

        private void KiralamaFormu_Load(object sender, EventArgs e)
        {
            // Müşteri ve Araç ComboBox'larını doldur
            MüşteriComboDoldur();
            AraçComboDoldur();
        }

        private void MüşteriComboDoldur()
        {
            // Sadece aktif müşterileri getiren sorgu
            string sorgu = "SELECT MüşteriID, Ad + ' ' + Soyad + ' (' + RIGHT(KimlikNo, 2) + ')' AS MusteriBilgisi FROM Müşteriler WHERE Durum = 'Aktif'";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMusteri.DataSource = dt;
                cmbMusteri.DisplayMember = "MusteriBilgisi";
                cmbMusteri.ValueMember = "MüşteriID";
            }
        }

        private void AraçComboDoldur()
        {
            // Sadece "Müsait" durumdaki ve "Aktif" varlık durumundaki araçları getiren sorgu
            string sorgu = "SELECT AracID, Marka + ' ' + Model + ' (' + Plaka + ')' AS AracBilgisi " +
                           "FROM Araclar WHERE Durum = 'Müsait' AND VarlikDurumu = 'Aktif'";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbArac.DataSource = dt;
                cmbArac.DisplayMember = "AracBilgisi";
                cmbArac.ValueMember = "AracID";
                cmbArac.SelectedIndex = -1; // Başlangıçta bir öğe seçilmemiş olsun
            }
        }





        private void btnKirala_Click(object sender, EventArgs e)
        {
            // Girdi Kontrolleri
            if (cmbMusteri.SelectedValue == null || cmbArac.SelectedValue == null)
            {
                MessageBox.Show("Lütfen müşteri ve araç seçimi yapın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtGunlukUcret.Text, out decimal gunlukUcret) || gunlukUcret <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir günlük ücret girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date;

            if (baslangic > bitis)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Toplam Ücreti Hesapla
            TimeSpan kiralamaSuresi = bitis - baslangic;
            int gunSayisi = kiralamaSuresi.Days + 1; // Aynı gün için 1 günlük ücret alınacak
            decimal toplamUcret = gunSayisi * gunlukUcret;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    // Araç Durumu Kontrolü
                    string durumSorgu = "SELECT Durum FROM Araclar WHERE AracID = @AracID";
                    SqlCommand durumKomut = new SqlCommand(durumSorgu, baglanti);
                    durumKomut.Parameters.AddWithValue("@AracID", cmbArac.SelectedValue);

                    baglanti.Open();
                    string durum = durumKomut.ExecuteScalar()?.ToString();
                    baglanti.Close();

                    if (durum != "Müsait")
                    {
                        MessageBox.Show($"Seçtiğiniz araç şu anda {durum.ToLower()}!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiralama işlemini ekle
                    string kiralamaSorgu = @"
                INSERT INTO Kiralama (MusteriID, AracID, BaslangicTarihi, BitisTarihi, GunlukUcret, ToplamUcret)
                VALUES (@MusteriID, @AracID, @BaslangicTarihi, @BitisTarihi, @GunlukUcret, @ToplamUcret)";

                    SqlCommand komut = new SqlCommand(kiralamaSorgu, baglanti);
                    komut.Parameters.AddWithValue("@MusteriID", cmbMusteri.SelectedValue);
                    komut.Parameters.AddWithValue("@AracID", cmbArac.SelectedValue);
                    komut.Parameters.AddWithValue("@BaslangicTarihi", baslangic);
                    komut.Parameters.AddWithValue("@BitisTarihi", bitis);
                    komut.Parameters.AddWithValue("@GunlukUcret", gunlukUcret);
                    komut.Parameters.AddWithValue("@ToplamUcret", toplamUcret);

                    // Aracın Kiralama Sayısını Güncelle ve Durumunu "Kirada" yap
                    string aracGuncelleSorgu = @"
                UPDATE Araclar 
                SET KiralamaSayisi = KiralamaSayisi + 1, Durum = 'Rezerve' 
                WHERE AracID = @AracID";
                    SqlCommand aracKomut = new SqlCommand(aracGuncelleSorgu, baglanti);
                    aracKomut.Parameters.AddWithValue("@AracID", cmbArac.SelectedValue);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    aracKomut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Araç başarıyla kiralandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblToplamUcret.Text = $"Toplam Ücret: {toplamUcret:C}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void HesaplaToplamUcret()
        {
            if (decimal.TryParse(txtGunlukUcret.Text, out decimal gunlukFiyat) &&
                dtpBaslangic.Value <= dtpBitis.Value)
            {
                TimeSpan kiralamaSuresi = dtpBitis.Value.Date - dtpBaslangic.Value.Date;
                int gunSayisi = kiralamaSuresi.Days + 1; // Aynı gün için 1 günlük ücret alınacak

                lblToplamUcret.Text = (gunSayisi * gunlukFiyat).ToString("C2");
            }
            else
            {
                lblToplamUcret.Text = "0,00 ₺";
            }
        }

        private void txtGunlukUcret_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplamUcret();
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            HesaplaToplamUcret();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            HesaplaToplamUcret();
        }

        private void cmbArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArac.SelectedValue != null && cmbArac.SelectedValue is int aracID) // Eğer int tipindeyse işlemi başlat
            {
                try
                {
                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        string sorgu = "SELECT GunlukFiyat FROM Araclar WHERE AracID = @AracID";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@AracID", aracID); // Doğrudan integer ID kullanımı

                        baglanti.Open();
                        object sonuc = komut.ExecuteScalar();
                        baglanti.Close();

                        if (sonuc != null)
                        {
                            decimal gunlukUcret = Convert.ToDecimal(sonuc);
                            lblStandartUcret.Text = $"Aracın standart günlük ücreti: {gunlukUcret:C2}";
                        }
                        else
                        {
                            lblStandartUcret.Text = "Aracın standart günlük ücreti: Bilinmiyor";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Günlük ücret alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblStandartUcret.Text = "Aracın standart günlük ücreti: Bilinmiyor";
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class AnaSayfa : Form
    {
        // Sql bağlantı dizesi
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";


        private System.Windows.Forms.Timer timer;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        // Saat ve tarih güncellemeleri
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss"); // Saat formatı
            lblTarih.Text = DateTime.Now.ToString("dd MMMM yyyy"); // Tarih formatı
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            // Araç Ekle Formu'nu aç
            AracEkleFormu aracEkleFormu = new AracEkleFormu();
            aracEkleFormu.ShowDialog();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            AracSilFormu aracSilFormu = new AracSilFormu();
            aracSilFormu.ShowDialog();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            AracGuncelle aracGuncelle = new AracGuncelle();
            aracGuncelle.ShowDialog();
        }

        private void btnAraclariListele_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.ShowDialog();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.ShowDialog();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            MusteriSil musteriSil = new MusteriSil();
            musteriSil.ShowDialog();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle musteriGuncelle = new MusteriGuncelle();
            musteriGuncelle.ShowDialog();
        }

        private void btnMusterileriListele_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.ShowDialog();
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            KiralamaFormu kiralamaFormu = new KiralamaFormu();
            kiralamaFormu.ShowDialog();
        }

        private void btnKiralamaGecmisi_Click(object sender, EventArgs e)
        {
            KiralamaGecmisi kiralamaGecmisi = new KiralamaGecmisi();
            kiralamaGecmisi.ShowDialog();
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan onay isteyen bir mesaj kutusu aç
            DialogResult sonuc = MessageBox.Show(
                "Oturumu kapatmak istediğinizden emin misiniz?",
                "Oturum Kapat",
                MessageBoxButtons.YesNo,       // Evet ve Hayır seçenekleri
                MessageBoxIcon.Question);     // Soru işareti simgesi

            // Kullanıcı "Evet" seçerse giriş sayfasına dön
            if (sonuc == DialogResult.Yes)
            {
                // Giriş sayfasını (Form1) yeniden oluştur ve göster
                Form1 loginForm = new Form1();
                loginForm.Show();

                // Mevcut formu kapat
                this.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan onay isteyen bir mesaj kutusu aç
            DialogResult sonuc = MessageBox.Show(
                "Programdan çıkmak istediğinizden emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,       // Evet ve Hayır seçenekleri
                MessageBoxIcon.Question);     // Soru işareti simgesi

            // Kullanıcı "Evet" seçerse uygulamayı kapat
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit(); // Programı tamamen kapatır
            }
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

            // *> Kiralama tarihini göre araçların durumunu "Müsait" veya "Kirada" yapma ---------------
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    string sorgu = @"
                    -- Kiralama bitiş tarihi geçmiş araçları 'Müsait' yap
                    UPDATE Araclar
                    SET Durum = 'Müsait'
                    WHERE AracID IN (
                        SELECT AracID
                        FROM Kiralama
                        WHERE BitisTarihi < GETDATE()
                    );

                    -- Kiralama tarihleri arasında olan araçları 'Kirada' yap
                    UPDATE Araclar
                    SET Durum = 'Kirada'
                    WHERE AracID IN (
                        SELECT AracID
                        FROM Kiralama
                        WHERE BaslangicTarihi <= GETDATE() AND BitisTarihi >= GETDATE()
                    );";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    baglanti.Open();
                    int etkilenenKayit = komut.ExecuteNonQuery();
                    baglanti.Close();

                    /*  if (etkilenenKayit > 0)
                    {
                        MessageBox.Show($"{etkilenenKayit} kayıt durumu güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiralama tarihini göre araçların durumunu "Müsait" veya "Kirada" yapma <* ---------------


            // *> Formun opaklığı %0 , fade-in efektini başlat --------------
            System.Windows.Forms.Timer fadeInTimer = new System.Windows.Forms.Timer();
            fadeInTimer.Interval = 30; // 30ms interval
            fadeInTimer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05; // Opaklık arttıkça görsel görünür olacak
                }
                else
                {
                    fadeInTimer.Stop(); // Efekt tamamlandığında stop et
                }
            };
            fadeInTimer.Start();

            // Saat ve tarih güncelleme için Timer'ı başlat
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000ms = 1 saniye
            timer.Tick += Timer_Tick;
            timer.Start();
            // Formun opaklığı %0 , fade-in efektini başlat <* ---------------
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            GelirFormu gelirFormu = new GelirFormu();
            gelirFormu.ShowDialog();
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            GiderFormu giderFormu = new GiderFormu();
            giderFormu.ShowDialog();
        }

        private void btnMuhasebeGor_Click(object sender, EventArgs e)
        {
            MuhasebeFormu muhasebeFormu = new MuhasebeFormu();
            muhasebeFormu.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class GelirFormu : Form
    {
        // SQL Server bağlantı dizesi
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        System.Windows.Forms.Timer timer;

        public GelirFormu()
        {
            InitializeComponent();
            InitializeDateTimeLabels();
        }

        private void InitializeDateTimeLabels()
        {
            // Timer oluştur ve ayarla
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 saniye (1000 milisaniye)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // lblTarih ve lblSaat'in içeriğini güncelle
            lblTarihBilgisi.Text = DateTime.Now.ToString("dd MMMM yyyy"); // Örneğin: 11 Ocak 2025
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");      // Örneğin: 14:35:45
        }

        private void GelirFormu_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Now; // Bugünkü tarih varsayılan.
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                   Color.Green, Color.White, 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void btnGir_Click(object sender, EventArgs e)
        {
            try
            {
                // Tutar kontrolü
                if (string.IsNullOrWhiteSpace(txtTutar.Text) || !decimal.TryParse(txtTutar.Text, out decimal tutar) || tutar <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tarih kontrolü
                DateTime secilenTarih = dtpTarih.Value;

                // Veritabanı ekleme
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    string sorgu = "INSERT INTO Gelir (Tarih, Aciklama, Tutar) VALUES (@Tarih, @Aciklama, @Tutar)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@Tarih", secilenTarih);
                    komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text.Trim());
                    komut.Parameters.AddWithValue("@Tutar", tutar);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

                MessageBox.Show("Gelir başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Alanları sıfırla
                txtTutar.Clear();
                txtAciklama.Clear();
                dtpTarih.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

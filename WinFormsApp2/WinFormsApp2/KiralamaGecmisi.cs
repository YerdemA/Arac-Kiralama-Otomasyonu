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
    public partial class KiralamaGecmisi : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public KiralamaGecmisi()
        {
            InitializeComponent();
        }
        private void KiralamaGecmisi_Load(object sender, EventArgs e)
        {
            rbTarihY_E.Checked = true; // Varsayılan sıralama yeni -> eski şeklinde
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string siralamaKriteri = "K.BaslangicTarihi"; // Varsayılan olarak başlangıç tarihine göre sıralama
            string siralamaTuru = "ASC"; // Varsayılan sıralama türü (Artan)

            // RadioButton kontrollerine göre sıralama kriterini belirle
            if (rbTarihY_E.Checked)
                siralamaKriteri = "K.BaslangicTarihi";
            else if (rbTarihE_Y.Checked)
                siralamaKriteri = "K.BaslangicTarihi";
            else if (rbGunlukUcretArtan.Checked)
                siralamaKriteri = "K.GunlukUcret";
            else if (rbGunlukUcretAzalan.Checked)
            {
                siralamaKriteri = "K.GunlukUcret";
                siralamaTuru = "DESC";
            }
            else if (rbToplamUcretArtan.Checked)
                siralamaKriteri = "DATEDIFF(DAY, K.BaslangicTarihi, K.BitisTarihi) * K.GunlukUcret";
            else if (rbToplamUcretAzalan.Checked)
            {
                siralamaKriteri = "DATEDIFF(DAY, K.BaslangicTarihi, K.BitisTarihi) * K.GunlukUcret";
                siralamaTuru = "DESC";
            }

            // SQL sorgusunu oluştur
            string sorgu = $@"
        SELECT 
            K.KiralamaID,
            M.Ad + ' ' + M.Soyad AS Musteri,
            A.Marka + ' ' + A.Model + ' (' + A.Plaka + ')' AS Arac,
            K.BaslangicTarihi,
            K.BitisTarihi,
            K.GunlukUcret,
            DATEDIFF(DAY, K.BaslangicTarihi, K.BitisTarihi) * K.GunlukUcret AS ToplamUcret
        FROM 
            Kiralama K
        JOIN 
            Müşteriler M ON K.MusteriID = M.MüşteriID
        JOIN 
            Araclar A ON K.AracID = A.AracID
        ORDER BY 
            {siralamaKriteri} {siralamaTuru}";

            // Verileri doldur
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKiralamaGecmisi.DataSource = dt;
            }
        }

    }
}

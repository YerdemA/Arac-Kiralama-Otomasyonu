using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class MusteriGuncelle : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Sözlük ile comboBox elemanlarını tablo sütunlarıyla eşleştiriyoruz.
        private readonly Dictionary<string, string> aramaKolonlari = new Dictionary<string, string>
        {
            { "Ad", "Ad" },
            { "Soyad", "Soyad" },
            { "Tc Kimlik Numarası", "KimlikNo" },
            { "Telefon Numarası", "TelefonNo" },
            { "E-Mail", "EMail" },
            { "Doğum Tarihi", "DogumTarihi" }
        };

        public MusteriGuncelle()
        {
            InitializeComponent();
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            // cmbAramaKolonu ComboBox'ını dolduruyoruz
            cmbAramaKolonu.DataSource = new BindingSource(aramaKolonlari, null);
            cmbAramaKolonu.DisplayMember = "Key";
            cmbAramaKolonu.ValueMember = "Value";

            // Durum comboBox'ını dolduruyoruz
            cmbDurum.Items.Add("Aktif");
            cmbDurum.Items.Add("Pasif");

            MusterileriGetir();
        }

        private void MusterileriGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Müşteriler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvMusteriler.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteriler getirilirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string seciliKolon = ((KeyValuePair<string, string>)cmbAramaKolonu.SelectedItem).Value;
            string aramaMetni = txtArama.Text;

            if (seciliKolon == "DogumTarihi")
            {
                if (!DateTime.TryParse(aramaMetni, out _))
                {
                    lblTarihUyarisi.Text = "Tarih formatı geçersiz! (örn. yyyy-MM-dd)";
                    return;
                }
                lblTarihUyarisi.Text = string.Empty;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT * FROM Müşteriler WHERE {seciliKolon} LIKE @Arama";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Arama", "%" + aramaMetni + "%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvMusteriler.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void dgvMusteriler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMusteriler.SelectedRows[0];
                txtKimlikNo.Text = row.Cells["KimlikNo"].Value.ToString();
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTelefonNo.Text = row.Cells["TelefonNo"].Value.ToString();
                txtEmail.Text = row.Cells["EMail"].Value.ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);

                // Durum bilgisini ComboBox'a yansıtıyoruz
                string durum = row.Cells["Durum"].Value.ToString();
                cmbDurum.SelectedItem = durum;  // Aktif veya Pasif olarak seçilecek
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                // Alanları kontrol et
                if (string.IsNullOrWhiteSpace(txtKimlikNo.Text))
                {
                    MessageBox.Show("Kimlik No alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAd.Text))
                {
                    MessageBox.Show("Ad alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSoyad.Text))
                {
                    MessageBox.Show("Soyad alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTelefonNo.Text))
                {
                    MessageBox.Show("Telefon No alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email alanı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Durumu ComboBox'tan alıyoruz
                string durum = cmbDurum.SelectedItem.ToString();

                // Doğru formatta girildiğini kontrol et
                if (!Regex.IsMatch(txtKimlikNo.Text, @"^\d{11}$"))
                {
                    MessageBox.Show("Kimlik No 11 haneli bir sayı olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(txtTelefonNo.Text, @"^\+?\d{10,13}$"))
                {
                    MessageBox.Show("Telefon No geçerli bir formatta olmalıdır (örn. +905555555555).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Email geçerli bir formatta olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int musteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells["MüşteriID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = @"UPDATE Müşteriler 
                                 SET KimlikNo = @KimlikNo, 
                                     Ad = @Ad, 
                                     Soyad = @Soyad, 
                                     TelefonNo = @TelefonNo, 
                                     EMail = @Email, 
                                     DogumTarihi = @DogumTarihi, 
                                     Durum = @Durum
                                 WHERE MüşteriID = @MüşteriID";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MüşteriID", musteriId);
                        command.Parameters.AddWithValue("@KimlikNo", txtKimlikNo.Text);
                        command.Parameters.AddWithValue("@Ad", txtAd.Text);
                        command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                        command.Parameters.AddWithValue("@TelefonNo", txtTelefonNo.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value);
                        command.Parameters.AddWithValue("@Durum", durum);  // Durum bilgisini ekliyoruz

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        connection.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MusterileriGetir();
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
                MessageBox.Show("Lütfen bir müşteri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void girisPaneliniTemizle()
        {
            txtKimlikNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefonNo.Clear();
            txtEmail.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            girisPaneliniTemizle();
        }

        private void cmbAramaKolonu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili öğeyi al
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

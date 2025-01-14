using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class MusteriSil : Form
    {
        string connectionString = @"Server=MONSTER\SQLEXPRESS;Database=AracKiralamaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public MusteriSil()
        {
            InitializeComponent();
        }

        private void MusteriSil_Load(object sender, EventArgs e)
        {
            MusterileriGetir(); // Varsayılan olarak tabloyu yükle
            cmbAramaKolonu.Items.AddRange(new string[] { "Ad", "Soyad", "KimlikNo", "TelefonNo", "EMail", "DogumTarihi" });
        }

        private void MusterileriGetir(string filterColumn = "", string filterValue = "", string orderBy = "ASC")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Müşteriler WHERE Durum = 'Aktif'"; // Sadece aktif müşteriler

                    if (!string.IsNullOrEmpty(filterColumn) && !string.IsNullOrEmpty(filterValue))
                    {
                        query += $" AND {filterColumn} LIKE @FilterValue";
                    }

                    query += $" ORDER BY MüşteriID {orderBy}";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    if (!string.IsNullOrEmpty(filterValue))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@FilterValue", "%" + filterValue + "%");
                    }

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

        private void rbIdK_B_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIdK_B.Checked)
            {
                MusterileriGetir(orderBy: "ASC");
            }
        }

        private void rbIdB_K_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIdB_K.Checked)
            {
                MusterileriGetir(orderBy: "DESC");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                string kimlikNo = dgvMusteriler.SelectedRows[0].Cells["KimlikNo"].Value.ToString();

                DialogResult result = MessageBox.Show("Seçili müşteriyi pasif hale getirmek istediğinizden emin misiniz?",
                                                      "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Müşteriyi pasif hale getirme
                            string query = "UPDATE Müşteriler SET Durum = 'Pasif' WHERE KimlikNo = @KimlikNo";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@KimlikNo", kimlikNo);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Müşteri başarıyla pasif hale getirildi.");
                                    MusterileriGetir(); // Tabloyu yenile
                                }
                                else
                                {
                                    MessageBox.Show("Müşteri pasif hale getirilirken bir sorun oluştu.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen pasif hale getirmek istediğiniz müşteriyi seçin.");
            }
        }

        private void cmbAramaKolonu_SelectedIndexChanged(object sender, EventArgs e)
        { // Seçili özellik doğum tarihi ise uyarı label'ını göster
            lblTarihUyarisi.Visible = cmbAramaKolonu.SelectedItem.ToString() == "DogumTarihi";
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (cmbAramaKolonu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir arama kolonu seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filterColumn = cmbAramaKolonu.SelectedItem.ToString();
            string filterValue = txtArama.Text;
            MusterileriGetir(filterColumn, filterValue);
        }
    }
}

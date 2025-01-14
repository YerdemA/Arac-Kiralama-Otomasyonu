namespace WinFormsApp2
{
    partial class MusteriGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelle));
            dgvMusteriler = new DataGridView();
            lblMusteriSil = new Label();
            btnGuncelle = new Button();
            panel1 = new Panel();
            cmbDurum = new ComboBox();
            label7 = new Label();
            btnTemizle = new Button();
            dtpDogumTarihi = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefonNo = new TextBox();
            txtKimlikNo = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblAd = new Label();
            pnlArama = new Panel();
            label1 = new Label();
            lblKolon = new Label();
            lblArama = new Label();
            cmbAramaKolonu = new ComboBox();
            txtArama = new TextBox();
            lblTarihUyarisi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            panel1.SuspendLayout();
            pnlArama.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.BackgroundColor = Color.Gainsboro;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(12, 90);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(663, 578);
            dgvMusteriler.TabIndex = 0;
            dgvMusteriler.SelectionChanged += dgvMusteriler_SelectionChanged;
            // 
            // lblMusteriSil
            // 
            lblMusteriSil.AutoSize = true;
            lblMusteriSil.BackColor = Color.Transparent;
            lblMusteriSil.Font = new Font("Goudy Stout", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusteriSil.ForeColor = Color.Snow;
            lblMusteriSil.Location = new Point(200, 12);
            lblMusteriSil.Name = "lblMusteriSil";
            lblMusteriSil.Size = new Size(923, 58);
            lblMusteriSil.TabIndex = 2;
            lblMusteriSil.Text = "< Musteri Guncelle >";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Black;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Cooper Black", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuncelle.ForeColor = Color.Snow;
            btnGuncelle.Location = new Point(1045, 555);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(298, 120);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(cmbDurum);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(dtpDogumTarihi);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtTelefonNo);
            panel1.Controls.Add(txtKimlikNo);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblAd);
            panel1.Location = new Point(681, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 412);
            panel1.TabIndex = 7;
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 15F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(181, 363);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(151, 43);
            cmbDurum.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 365);
            label7.Name = "label7";
            label7.Size = new Size(159, 37);
            label7.TabIndex = 12;
            label7.Text = "DURUM :";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Snow;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTemizle.Location = new Point(473, 8);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(206, 68);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "TEMIZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 15F);
            dtpDogumTarihi.Location = new Point(291, 311);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(304, 41);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(187, 255);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 41);
            txtEmail.TabIndex = 10;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Font = new Font("Segoe UI", 15F);
            txtTelefonNo.Location = new Point(214, 193);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(304, 41);
            txtTelefonNo.TabIndex = 9;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Font = new Font("Segoe UI", 15F);
            txtKimlikNo.Location = new Point(268, 137);
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(304, 41);
            txtKimlikNo.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 15F);
            txtSoyad.Location = new Point(163, 77);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(304, 41);
            txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 15F);
            txtAd.Location = new Point(101, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(304, 41);
            txtAd.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 315);
            label6.Name = "label6";
            label6.Size = new Size(275, 37);
            label6.TabIndex = 5;
            label6.Text = "DOGUM TARiHi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 79);
            label5.Name = "label5";
            label5.Size = new Size(146, 37);
            label5.TabIndex = 4;
            label5.Text = "SOYAD :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 139);
            label4.Name = "label4";
            label4.Size = new Size(254, 37);
            label4.TabIndex = 3;
            label4.Text = "TC KiMLiK NO :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 195);
            label3.Name = "label3";
            label3.Size = new Size(199, 37);
            label3.TabIndex = 2;
            label3.Text = "Telefon No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 257);
            label2.Name = "label2";
            label2.Size = new Size(165, 37);
            label2.TabIndex = 1;
            label2.Text = "E - Mail :";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAd.Location = new Point(11, 24);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(84, 37);
            lblAd.TabIndex = 0;
            lblAd.Text = "AD :";
            // 
            // pnlArama
            // 
            pnlArama.BackColor = Color.Black;
            pnlArama.Controls.Add(label1);
            pnlArama.Controls.Add(lblKolon);
            pnlArama.Controls.Add(lblArama);
            pnlArama.Controls.Add(cmbAramaKolonu);
            pnlArama.Controls.Add(txtArama);
            pnlArama.Location = new Point(776, 508);
            pnlArama.Name = "pnlArama";
            pnlArama.Size = new Size(221, 176);
            pnlArama.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Goudy Stout", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 14);
            label1.Name = "label1";
            label1.Size = new Size(209, 27);
            label1.TabIndex = 12;
            label1.Text = "* Arama *";
            // 
            // lblKolon
            // 
            lblKolon.AutoSize = true;
            lblKolon.BackColor = Color.Transparent;
            lblKolon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKolon.ForeColor = Color.Snow;
            lblKolon.Location = new Point(15, 50);
            lblKolon.Name = "lblKolon";
            lblKolon.Size = new Size(187, 20);
            lblKolon.TabIndex = 10;
            lblKolon.Text = "Aramak istediğiniz özellik";
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.BackColor = Color.Transparent;
            lblArama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblArama.ForeColor = Color.Snow;
            lblArama.Location = new Point(15, 111);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(178, 20);
            lblArama.TabIndex = 11;
            lblArama.Text = "Aramak istediğiniz ifade";
            // 
            // cmbAramaKolonu
            // 
            cmbAramaKolonu.Font = new Font("Segoe UI", 12F);
            cmbAramaKolonu.FormattingEnabled = true;
            cmbAramaKolonu.Items.AddRange(new object[] { "Ad", "Soyad", "Tc Kimlik Numarası", "Telefon Numarası", "E-Mail", "Doğum Tarihi" });
            cmbAramaKolonu.Location = new Point(15, 73);
            cmbAramaKolonu.Name = "cmbAramaKolonu";
            cmbAramaKolonu.Size = new Size(177, 36);
            cmbAramaKolonu.TabIndex = 7;
            cmbAramaKolonu.SelectedIndexChanged += cmbAramaKolonu_SelectedIndexChanged;
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 12F);
            txtArama.Location = new Point(15, 134);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(177, 34);
            txtArama.TabIndex = 8;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // lblTarihUyarisi
            // 
            lblTarihUyarisi.AutoSize = true;
            lblTarihUyarisi.BackColor = Color.DarkRed;
            lblTarihUyarisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarihUyarisi.ForeColor = Color.Snow;
            lblTarihUyarisi.Location = new Point(601, 508);
            lblTarihUyarisi.Name = "lblTarihUyarisi";
            lblTarihUyarisi.Size = new Size(184, 92);
            lblTarihUyarisi.TabIndex = 15;
            lblTarihUyarisi.Text = "Tarih girişini \r\nyyyy-mm-dd\r\nformatında yapınız! \r\nÖrneğin : 2005-08-23\r\n";
            lblTarihUyarisi.Visible = false;
            // 
            // MusteriGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1402, 696);
            Controls.Add(lblTarihUyarisi);
            Controls.Add(pnlArama);
            Controls.Add(panel1);
            Controls.Add(btnGuncelle);
            Controls.Add(lblMusteriSil);
            Controls.Add(dgvMusteriler);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MusteriGuncelle";
            Text = "Müşteri Güncelle";
            Load += MusteriGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlArama.ResumeLayout(false);
            pnlArama.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMusteriler;
        private Label lblMusteriSil;
        private Button btnGuncelle;
        private Panel panel1;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtEmail;
        private TextBox txtTelefonNo;
        private TextBox txtKimlikNo;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblAd;
        private Button btnTemizle;
        private Panel pnlArama;
        private Label label1;
        private Label lblKolon;
        private Label lblArama;
        private ComboBox cmbAramaKolonu;
        private TextBox txtArama;
        private Label lblTarihUyarisi;
        private ComboBox cmbDurum;
        private Label label7;
    }
}
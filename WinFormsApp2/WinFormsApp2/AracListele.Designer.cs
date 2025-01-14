namespace WinFormsApp2
{
    partial class AracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListele));
            dgvAraclar = new DataGridView();
            label1 = new Label();
            gBoxSiralama = new GroupBox();
            rbKilometreY_D = new RadioButton();
            rbKilometreD_Y = new RadioButton();
            rbFiyatY_D = new RadioButton();
            rbFiyatD_Y = new RadioButton();
            btnListele = new Button();
            cmbAramaKolonu = new ComboBox();
            txtArama = new TextBox();
            lblKolon = new Label();
            lblArama = new Label();
            pnlArama = new Panel();
            label2 = new Label();
            lblTarihUyarisi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            gBoxSiralama.SuspendLayout();
            pnlArama.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAraclar
            // 
            dgvAraclar.BackgroundColor = Color.WhiteSmoke;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(12, 105);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.RowHeadersWidth = 51;
            dgvAraclar.Size = new Size(927, 631);
            dgvAraclar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Goudy Stout", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(337, 18);
            label1.Name = "label1";
            label1.Size = new Size(602, 68);
            label1.TabIndex = 3;
            label1.Text = "< Araçlar >";
            // 
            // gBoxSiralama
            // 
            gBoxSiralama.BackColor = Color.Transparent;
            gBoxSiralama.Controls.Add(rbKilometreY_D);
            gBoxSiralama.Controls.Add(rbKilometreD_Y);
            gBoxSiralama.Controls.Add(rbFiyatY_D);
            gBoxSiralama.Controls.Add(rbFiyatD_Y);
            gBoxSiralama.FlatStyle = FlatStyle.Flat;
            gBoxSiralama.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gBoxSiralama.ForeColor = Color.Snow;
            gBoxSiralama.Location = new Point(1039, 18);
            gBoxSiralama.Name = "gBoxSiralama";
            gBoxSiralama.Size = new Size(219, 152);
            gBoxSiralama.TabIndex = 5;
            gBoxSiralama.TabStop = false;
            gBoxSiralama.Text = "Sıralama Seçeneği";
            // 
            // rbKilometreY_D
            // 
            rbKilometreY_D.AutoSize = true;
            rbKilometreY_D.Font = new Font("Lucida Fax", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbKilometreY_D.Location = new Point(6, 117);
            rbKilometreY_D.Name = "rbKilometreY_D";
            rbKilometreY_D.Size = new Size(203, 20);
            rbKilometreY_D.TabIndex = 3;
            rbKilometreY_D.TabStop = true;
            rbKilometreY_D.Text = "Km - Yüksekten Düşüğe";
            rbKilometreY_D.UseVisualStyleBackColor = true;
            // 
            // rbKilometreD_Y
            // 
            rbKilometreD_Y.AutoSize = true;
            rbKilometreD_Y.Font = new Font("Lucida Fax", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbKilometreD_Y.Location = new Point(6, 87);
            rbKilometreD_Y.Name = "rbKilometreD_Y";
            rbKilometreD_Y.Size = new Size(203, 20);
            rbKilometreD_Y.TabIndex = 2;
            rbKilometreD_Y.TabStop = true;
            rbKilometreD_Y.Text = "Km - Düşükten Yükseğe";
            rbKilometreD_Y.UseVisualStyleBackColor = true;
            // 
            // rbFiyatY_D
            // 
            rbFiyatY_D.AutoSize = true;
            rbFiyatY_D.Font = new Font("Lucida Fax", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFiyatY_D.Location = new Point(6, 57);
            rbFiyatY_D.Name = "rbFiyatY_D";
            rbFiyatY_D.Size = new Size(213, 20);
            rbFiyatY_D.TabIndex = 1;
            rbFiyatY_D.TabStop = true;
            rbFiyatY_D.Text = "Fiyat - Yüksekten Düşüğe";
            rbFiyatY_D.UseVisualStyleBackColor = true;
            // 
            // rbFiyatD_Y
            // 
            rbFiyatD_Y.AutoSize = true;
            rbFiyatD_Y.Font = new Font("Lucida Fax", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFiyatD_Y.Location = new Point(6, 27);
            rbFiyatD_Y.Name = "rbFiyatD_Y";
            rbFiyatD_Y.Size = new Size(213, 20);
            rbFiyatD_Y.TabIndex = 0;
            rbFiyatD_Y.TabStop = true;
            rbFiyatD_Y.Text = "Fiyat - Düşükten Yükseğe";
            rbFiyatD_Y.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.Black;
            btnListele.BackgroundImage = Properties.Resources.koyuAracEkle;
            btnListele.BackgroundImageLayout = ImageLayout.Stretch;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListele.ForeColor = Color.Snow;
            btnListele.Location = new Point(1117, 176);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(141, 110);
            btnListele.TabIndex = 6;
            btnListele.Text = "Sırala";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // cmbAramaKolonu
            // 
            cmbAramaKolonu.Font = new Font("Segoe UI", 12F);
            cmbAramaKolonu.FormattingEnabled = true;
            cmbAramaKolonu.Items.AddRange(new object[] { "Plaka", "Marka", "Model", "Durum", "Günlük Fiyat", "Üretim Yılı", "Araç Tipi", "Yakıt Tipi", "Vites Tipi", "Koltuk Sayısı", "Renk", "Kilometre Bilgisi", "Son Bakım Tarihi", "Garanti Durumu", "Kiralama Sayısı", "Sigorta Tarihi" });
            cmbAramaKolonu.Location = new Point(15, 76);
            cmbAramaKolonu.Name = "cmbAramaKolonu";
            cmbAramaKolonu.Size = new Size(177, 36);
            cmbAramaKolonu.TabIndex = 7;
            cmbAramaKolonu.SelectedIndexChanged += cmbAramaKolonu_SelectedIndexChanged;
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 12F);
            txtArama.Location = new Point(15, 144);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(177, 34);
            txtArama.TabIndex = 8;
            txtArama.KeyUp += txtArama_KeyUp;
            // 
            // lblKolon
            // 
            lblKolon.AutoSize = true;
            lblKolon.BackColor = Color.Transparent;
            lblKolon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKolon.ForeColor = Color.Snow;
            lblKolon.Location = new Point(15, 53);
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
            lblArama.Location = new Point(15, 121);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(178, 20);
            lblArama.TabIndex = 11;
            lblArama.Text = "Aramak istediğiniz ifade";
            // 
            // pnlArama
            // 
            pnlArama.BackColor = Color.Gainsboro;
            pnlArama.BackgroundImage = Properties.Resources.btnSil;
            pnlArama.Controls.Add(label2);
            pnlArama.Controls.Add(lblKolon);
            pnlArama.Controls.Add(lblArama);
            pnlArama.Controls.Add(cmbAramaKolonu);
            pnlArama.Controls.Add(txtArama);
            pnlArama.Location = new Point(1027, 304);
            pnlArama.Name = "pnlArama";
            pnlArama.Size = new Size(221, 191);
            pnlArama.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Goudy Stout", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 11);
            label2.Name = "label2";
            label2.Size = new Size(209, 27);
            label2.TabIndex = 12;
            label2.Text = "* Arama *";
            // 
            // lblTarihUyarisi
            // 
            lblTarihUyarisi.AutoSize = true;
            lblTarihUyarisi.BackColor = Color.MidnightBlue;
            lblTarihUyarisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarihUyarisi.ForeColor = Color.Snow;
            lblTarihUyarisi.Location = new Point(1018, 498);
            lblTarihUyarisi.Name = "lblTarihUyarisi";
            lblTarihUyarisi.Size = new Size(240, 69);
            lblTarihUyarisi.TabIndex = 14;
            lblTarihUyarisi.Text = "Tarih girişlerini yyyy-mm-dd\r\nformatında yapınız! \r\nÖrneğin : 2005-08-23\r\n";
            lblTarihUyarisi.Visible = false;
            // 
            // AracListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.anaSarkaplan;
            ClientSize = new Size(1270, 739);
            Controls.Add(lblTarihUyarisi);
            Controls.Add(pnlArama);
            Controls.Add(btnListele);
            Controls.Add(gBoxSiralama);
            Controls.Add(label1);
            Controls.Add(dgvAraclar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AracListele";
            Text = "Araçlar";
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            gBoxSiralama.ResumeLayout(false);
            gBoxSiralama.PerformLayout();
            pnlArama.ResumeLayout(false);
            pnlArama.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAraclar;
        private Label label1;
        private GroupBox gBoxSiralama;
        private RadioButton rbKilometreY_D;
        private RadioButton rbKilometreD_Y;
        private RadioButton rbFiyatY_D;
        private RadioButton rbFiyatD_Y;
        private Button btnListele;
        private ComboBox cmbAramaKolonu;
        private TextBox txtArama;
        private Label lblKolon;
        private Label lblArama;
        private Panel pnlArama;
        private Label label2;
        private Label lblTarihUyarisi;
    }
}
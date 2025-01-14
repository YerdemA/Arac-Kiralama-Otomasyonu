namespace WinFormsApp2
{
    partial class AracEkleFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkleFormu));
            label1 = new Label();
            panel1 = new Panel();
            cmbGarantiDurumu = new ComboBox();
            btnIptal = new Button();
            btnEkle = new Button();
            cmbDurum = new ComboBox();
            txtFiyat = new TextBox();
            dtpSigorta = new DateTimePicker();
            lblGaranti = new Label();
            dtpSonBakim = new DateTimePicker();
            txtRenk = new TextBox();
            numKilometre = new NumericUpDown();
            numKoltukSayisi = new NumericUpDown();
            cmbVitesTipi = new ComboBox();
            cmbYakitTipi = new ComboBox();
            cmbAracTipi = new ComboBox();
            cmbUretimYili = new ComboBox();
            txtModel = new TextBox();
            txtMarka = new TextBox();
            txtPlaka = new TextBox();
            lblSigorta = new Label();
            lblFiyat = new Label();
            lblSonBakim = new Label();
            lblDurum = new Label();
            lblKilometre = new Label();
            lblRenk = new Label();
            lblKoltukSayisi = new Label();
            lblVitesTipi = new Label();
            lblYakitTipi = new Label();
            lblAracTipi = new Label();
            lblUretimYili = new Label();
            lblModel = new Label();
            lblMarka = new Label();
            lblPlaka = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKoltukSayisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 46);
            label1.TabIndex = 0;
            label1.Text = "Araç Ekle";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BackgroundImage = Properties.Resources.koyuAracEkle;
            panel1.Controls.Add(cmbGarantiDurumu);
            panel1.Controls.Add(btnIptal);
            panel1.Controls.Add(btnEkle);
            panel1.Controls.Add(cmbDurum);
            panel1.Controls.Add(txtFiyat);
            panel1.Controls.Add(dtpSigorta);
            panel1.Controls.Add(lblGaranti);
            panel1.Controls.Add(dtpSonBakim);
            panel1.Controls.Add(txtRenk);
            panel1.Controls.Add(numKilometre);
            panel1.Controls.Add(numKoltukSayisi);
            panel1.Controls.Add(cmbVitesTipi);
            panel1.Controls.Add(cmbYakitTipi);
            panel1.Controls.Add(cmbAracTipi);
            panel1.Controls.Add(cmbUretimYili);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(txtMarka);
            panel1.Controls.Add(txtPlaka);
            panel1.Controls.Add(lblSigorta);
            panel1.Controls.Add(lblFiyat);
            panel1.Controls.Add(lblSonBakim);
            panel1.Controls.Add(lblDurum);
            panel1.Controls.Add(lblKilometre);
            panel1.Controls.Add(lblRenk);
            panel1.Controls.Add(lblKoltukSayisi);
            panel1.Controls.Add(lblVitesTipi);
            panel1.Controls.Add(lblYakitTipi);
            panel1.Controls.Add(lblAracTipi);
            panel1.Controls.Add(lblUretimYili);
            panel1.Controls.Add(lblModel);
            panel1.Controls.Add(lblMarka);
            panel1.Controls.Add(lblPlaka);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(28, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 641);
            panel1.TabIndex = 1;
            // 
            // cmbGarantiDurumu
            // 
            cmbGarantiDurumu.Font = new Font("Segoe UI", 12F);
            cmbGarantiDurumu.FormattingEnabled = true;
            cmbGarantiDurumu.Items.AddRange(new object[] { "Var", "Yok" });
            cmbGarantiDurumu.Location = new Point(275, 586);
            cmbGarantiDurumu.Name = "cmbGarantiDurumu";
            cmbGarantiDurumu.Size = new Size(290, 36);
            cmbGarantiDurumu.TabIndex = 33;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Black;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Impact", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIptal.ForeColor = Color.Snow;
            btnIptal.Image = (Image)resources.GetObject("btnIptal.Image");
            btnIptal.Location = new Point(611, 318);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(125, 125);
            btnIptal.TabIndex = 31;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Transparent;
            btnEkle.BackgroundImage = Properties.Resources.koyuButon;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Impact", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkle.ForeColor = Color.Snow;
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.Location = new Point(611, 168);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 125);
            btnEkle.TabIndex = 30;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 12F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Müsait", "Rezerve", "Kirada", "Bakımda", "Diğer" });
            cmbDurum.Location = new Point(275, 545);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(290, 36);
            cmbDurum.TabIndex = 29;
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Segoe UI", 12F);
            txtFiyat.Location = new Point(275, 506);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(290, 34);
            txtFiyat.TabIndex = 28;
            // 
            // dtpSigorta
            // 
            dtpSigorta.Font = new Font("Segoe UI", 12F);
            dtpSigorta.Location = new Point(275, 465);
            dtpSigorta.Name = "dtpSigorta";
            dtpSigorta.Size = new Size(290, 34);
            dtpSigorta.TabIndex = 26;
            // 
            // lblGaranti
            // 
            lblGaranti.AutoSize = true;
            lblGaranti.BackColor = Color.Transparent;
            lblGaranti.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGaranti.ForeColor = Color.Snow;
            lblGaranti.Location = new Point(33, 589);
            lblGaranti.Name = "lblGaranti";
            lblGaranti.Size = new Size(242, 30);
            lblGaranti.TabIndex = 14;
            lblGaranti.Text = "Garanti Durumu :";
            // 
            // dtpSonBakim
            // 
            dtpSonBakim.Font = new Font("Segoe UI", 12F);
            dtpSonBakim.Location = new Point(275, 425);
            dtpSonBakim.Name = "dtpSonBakim";
            dtpSonBakim.Size = new Size(290, 34);
            dtpSonBakim.TabIndex = 25;
            // 
            // txtRenk
            // 
            txtRenk.Font = new Font("Segoe UI", 12F);
            txtRenk.Location = new Point(275, 344);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(290, 34);
            txtRenk.TabIndex = 24;
            // 
            // numKilometre
            // 
            numKilometre.Font = new Font("Segoe UI", 12F);
            numKilometre.Location = new Point(275, 384);
            numKilometre.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numKilometre.Name = "numKilometre";
            numKilometre.Size = new Size(290, 34);
            numKilometre.TabIndex = 23;
            // 
            // numKoltukSayisi
            // 
            numKoltukSayisi.Font = new Font("Segoe UI", 12F);
            numKoltukSayisi.Location = new Point(275, 302);
            numKoltukSayisi.Name = "numKoltukSayisi";
            numKoltukSayisi.Size = new Size(290, 34);
            numKoltukSayisi.TabIndex = 22;
            // 
            // cmbVitesTipi
            // 
            cmbVitesTipi.Font = new Font("Segoe UI", 12F);
            cmbVitesTipi.FormattingEnabled = true;
            cmbVitesTipi.Items.AddRange(new object[] { "Manuel", "Otomatik", "Yarı Otomatik", "CVT", "DSG", "Tiptronic", "Diğer" });
            cmbVitesTipi.Location = new Point(275, 262);
            cmbVitesTipi.Name = "cmbVitesTipi";
            cmbVitesTipi.Size = new Size(290, 36);
            cmbVitesTipi.TabIndex = 21;
            // 
            // cmbYakitTipi
            // 
            cmbYakitTipi.Font = new Font("Segoe UI", 12F);
            cmbYakitTipi.FormattingEnabled = true;
            cmbYakitTipi.Items.AddRange(new object[] { "Benzin", "Dizel", "Elektrik", "Hibrit", "LPG", "CNG", "Etanol", "Hidrojen", "Solar", "Diğer" });
            cmbYakitTipi.Location = new Point(275, 221);
            cmbYakitTipi.Name = "cmbYakitTipi";
            cmbYakitTipi.Size = new Size(290, 36);
            cmbYakitTipi.TabIndex = 20;
            // 
            // cmbAracTipi
            // 
            cmbAracTipi.Font = new Font("Segoe UI", 12F);
            cmbAracTipi.FormattingEnabled = true;
            cmbAracTipi.Items.AddRange(new object[] { "Sedan", "Hatchback", "Elektrikli", "SUV", "Pick-up", "Minibüs", "Coupe", "Cabriolet", "Roadster", "MPV", "Station Wagon" });
            cmbAracTipi.Location = new Point(275, 180);
            cmbAracTipi.Name = "cmbAracTipi";
            cmbAracTipi.Size = new Size(290, 36);
            cmbAracTipi.TabIndex = 19;
            // 
            // cmbUretimYili
            // 
            cmbUretimYili.Font = new Font("Segoe UI", 12F);
            cmbUretimYili.FormattingEnabled = true;
            cmbUretimYili.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            cmbUretimYili.Location = new Point(275, 139);
            cmbUretimYili.Name = "cmbUretimYili";
            cmbUretimYili.Size = new Size(290, 36);
            cmbUretimYili.TabIndex = 18;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 12F);
            txtModel.Location = new Point(275, 98);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(290, 34);
            txtModel.TabIndex = 17;
            // 
            // txtMarka
            // 
            txtMarka.Font = new Font("Segoe UI", 12F);
            txtMarka.Location = new Point(275, 57);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(290, 34);
            txtMarka.TabIndex = 16;
            // 
            // txtPlaka
            // 
            txtPlaka.Font = new Font("Segoe UI", 12F);
            txtPlaka.Location = new Point(275, 17);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(290, 34);
            txtPlaka.TabIndex = 15;
            // 
            // lblSigorta
            // 
            lblSigorta.AutoSize = true;
            lblSigorta.BackColor = Color.Transparent;
            lblSigorta.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSigorta.ForeColor = Color.Snow;
            lblSigorta.Location = new Point(53, 470);
            lblSigorta.Name = "lblSigorta";
            lblSigorta.Size = new Size(222, 30);
            lblSigorta.TabIndex = 13;
            lblSigorta.Text = "Sigorta Tarihi :";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.BackColor = Color.Transparent;
            lblFiyat.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiyat.ForeColor = Color.Snow;
            lblFiyat.Location = new Point(75, 510);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(200, 30);
            lblFiyat.TabIndex = 12;
            lblFiyat.Text = "Günlük Fiyat :";
            // 
            // lblSonBakim
            // 
            lblSonBakim.AutoSize = true;
            lblSonBakim.BackColor = Color.Transparent;
            lblSonBakim.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSonBakim.ForeColor = Color.Snow;
            lblSonBakim.Location = new Point(23, 429);
            lblSonBakim.Name = "lblSonBakim";
            lblSonBakim.Size = new Size(252, 30);
            lblSonBakim.TabIndex = 11;
            lblSonBakim.Text = "Son Bakim Tarihi :";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.BackColor = Color.Transparent;
            lblDurum.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDurum.ForeColor = Color.Snow;
            lblDurum.Location = new Point(161, 551);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(114, 30);
            lblDurum.TabIndex = 10;
            lblDurum.Text = "Durum :";
            // 
            // lblKilometre
            // 
            lblKilometre.AutoSize = true;
            lblKilometre.BackColor = Color.Transparent;
            lblKilometre.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKilometre.ForeColor = Color.Snow;
            lblKilometre.Location = new Point(13, 388);
            lblKilometre.Name = "lblKilometre";
            lblKilometre.Size = new Size(262, 30);
            lblKilometre.TabIndex = 9;
            lblKilometre.Text = "Kilometre Bilgisi :";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.BackColor = Color.Transparent;
            lblRenk.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRenk.ForeColor = Color.Snow;
            lblRenk.Location = new Point(181, 347);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(94, 30);
            lblRenk.TabIndex = 8;
            lblRenk.Text = "Renk :";
            // 
            // lblKoltukSayisi
            // 
            lblKoltukSayisi.AutoSize = true;
            lblKoltukSayisi.BackColor = Color.Transparent;
            lblKoltukSayisi.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKoltukSayisi.ForeColor = Color.Snow;
            lblKoltukSayisi.Location = new Point(67, 306);
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Size = new Size(208, 30);
            lblKoltukSayisi.TabIndex = 7;
            lblKoltukSayisi.Text = "Koltuk Sayisi :";
            // 
            // lblVitesTipi
            // 
            lblVitesTipi.AutoSize = true;
            lblVitesTipi.BackColor = Color.Transparent;
            lblVitesTipi.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVitesTipi.ForeColor = Color.Snow;
            lblVitesTipi.Location = new Point(122, 262);
            lblVitesTipi.Name = "lblVitesTipi";
            lblVitesTipi.Size = new Size(153, 30);
            lblVitesTipi.TabIndex = 6;
            lblVitesTipi.Text = "Vites Tipi :";
            // 
            // lblYakitTipi
            // 
            lblYakitTipi.AutoSize = true;
            lblYakitTipi.BackColor = Color.Transparent;
            lblYakitTipi.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYakitTipi.ForeColor = Color.Snow;
            lblYakitTipi.Location = new Point(118, 224);
            lblYakitTipi.Name = "lblYakitTipi";
            lblYakitTipi.Size = new Size(157, 30);
            lblYakitTipi.TabIndex = 5;
            lblYakitTipi.Text = "Yakit Tipi :";
            // 
            // lblAracTipi
            // 
            lblAracTipi.AutoSize = true;
            lblAracTipi.BackColor = Color.Transparent;
            lblAracTipi.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAracTipi.ForeColor = Color.Snow;
            lblAracTipi.Location = new Point(129, 183);
            lblAracTipi.Name = "lblAracTipi";
            lblAracTipi.Size = new Size(146, 30);
            lblAracTipi.TabIndex = 4;
            lblAracTipi.Text = "Araç Tipi :";
            // 
            // lblUretimYili
            // 
            lblUretimYili.AutoSize = true;
            lblUretimYili.BackColor = Color.Transparent;
            lblUretimYili.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUretimYili.ForeColor = Color.Snow;
            lblUretimYili.Location = new Point(100, 142);
            lblUretimYili.Name = "lblUretimYili";
            lblUretimYili.Size = new Size(175, 30);
            lblUretimYili.TabIndex = 3;
            lblUretimYili.Text = "Üretim Yili :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.BackColor = Color.Transparent;
            lblModel.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModel.ForeColor = Color.Snow;
            lblModel.Location = new Point(168, 101);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(107, 30);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model :";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.BackColor = Color.Transparent;
            lblMarka.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarka.ForeColor = Color.Snow;
            lblMarka.Location = new Point(163, 61);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(112, 30);
            lblMarka.TabIndex = 1;
            lblMarka.Text = "Marka :";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.BackColor = Color.Transparent;
            lblPlaka.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlaka.ForeColor = Color.Snow;
            lblPlaka.Location = new Point(171, 20);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(104, 30);
            lblPlaka.TabIndex = 0;
            lblPlaka.Text = "Plaka :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.klasAraba;
            pictureBox1.Location = new Point(611, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // AracEkleFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 711);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AracEkleFormu";
            Text = "Araç Ekle";
            Load += AracEkleFormu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometre).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKoltukSayisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblMarka;
        private Label lblPlaka;
        private Label lblGaranti;
        private Label lblSigorta;
        private Label lblFiyat;
        private Label lblSonBakim;
        private Label lblDurum;
        private Label lblKilometre;
        private Label lblRenk;
        private Label lblKoltukSayisi;
        private Label lblVitesTipi;
        private Label lblYakitTipi;
        private Label lblAracTipi;
        private Label lblUretimYili;
        private Label lblModel;
        private TextBox txtPlaka;
        private TextBox txtModel;
        private TextBox txtMarka;
        private DateTimePicker dtpSigorta;
        private DateTimePicker dtpSonBakim;
        private TextBox txtRenk;
        private NumericUpDown numKilometre;
        private NumericUpDown numKoltukSayisi;
        private ComboBox cmbVitesTipi;
        private ComboBox cmbYakitTipi;
        private ComboBox cmbAracTipi;
        private ComboBox cmbUretimYili;
        private TextBox txtFiyat;
        private ComboBox cmbDurum;
        private Button btnEkle;
        private Button btnIptal;
        private PictureBox pictureBox1;
        private ComboBox cmbGarantiDurumu;
    }
}
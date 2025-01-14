namespace WinFormsApp2
{
    partial class AracGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracGuncelle));
            lblAracGuncelle = new Label();
            dgvAraclar = new DataGridView();
            btnGuncelle = new Button();
            panel1 = new Panel();
            btnTemizle = new Button();
            cmbGarantiDurumu = new ComboBox();
            numKoltukSayisi = new NumericUpDown();
            lblKoltukSayisi = new Label();
            dtpSigortaTarihi = new DateTimePicker();
            dtpSonBakim = new DateTimePicker();
            numKilometre = new NumericUpDown();
            cmbDurum = new ComboBox();
            cmbVitesTipi = new ComboBox();
            cmbYakitTipi = new ComboBox();
            cmbAracTipi = new ComboBox();
            cmbUretimYili = new ComboBox();
            txtGunlukFiyat = new TextBox();
            txtRenk = new TextBox();
            txtModel = new TextBox();
            txtMarka = new TextBox();
            txtPlaka = new TextBox();
            lblDurum = new Label();
            lblUretimYili = new Label();
            lblAracTipi = new Label();
            lblYakitTipi = new Label();
            lblVitesTipi = new Label();
            lblRenk = new Label();
            lblKilometre = new Label();
            lblSonBakim = new Label();
            lblGarantiDurumu = new Label();
            lblSigortaTarihi = new Label();
            lblGunlukFiyat = new Label();
            lblModel = new Label();
            lblMarka = new Label();
            lblPlaka = new Label();
            lblTarihUyarisi = new Label();
            pnlArama = new Panel();
            label2 = new Label();
            lblKolon = new Label();
            lblArama = new Label();
            cmbAramaKolonu = new ComboBox();
            txtArama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKoltukSayisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKilometre).BeginInit();
            pnlArama.SuspendLayout();
            SuspendLayout();
            // 
            // lblAracGuncelle
            // 
            lblAracGuncelle.AutoSize = true;
            lblAracGuncelle.BackColor = Color.Transparent;
            lblAracGuncelle.Font = new Font("Goudy Stout", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAracGuncelle.ForeColor = Color.Snow;
            lblAracGuncelle.Location = new Point(141, 15);
            lblAracGuncelle.Name = "lblAracGuncelle";
            lblAracGuncelle.Size = new Size(903, 68);
            lblAracGuncelle.TabIndex = 3;
            lblAracGuncelle.Text = "< Araç Guncelle >";
            // 
            // dgvAraclar
            // 
            dgvAraclar.BackgroundColor = Color.WhiteSmoke;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(4, 108);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.RowHeadersWidth = 51;
            dgvAraclar.Size = new Size(600, 632);
            dgvAraclar.TabIndex = 4;
            dgvAraclar.SelectionChanged += dgvAraclar_SelectionChanged;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.MidnightBlue;
            btnGuncelle.BackgroundImage = (Image)resources.GetObject("btnGuncelle.BackgroundImage");
            btnGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuncelle.ForeColor = Color.Snow;
            btnGuncelle.Location = new Point(1107, 539);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(198, 88);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.btnSil;
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(cmbGarantiDurumu);
            panel1.Controls.Add(numKoltukSayisi);
            panel1.Controls.Add(lblKoltukSayisi);
            panel1.Controls.Add(dtpSigortaTarihi);
            panel1.Controls.Add(dtpSonBakim);
            panel1.Controls.Add(numKilometre);
            panel1.Controls.Add(cmbDurum);
            panel1.Controls.Add(cmbVitesTipi);
            panel1.Controls.Add(cmbYakitTipi);
            panel1.Controls.Add(cmbAracTipi);
            panel1.Controls.Add(cmbUretimYili);
            panel1.Controls.Add(txtGunlukFiyat);
            panel1.Controls.Add(txtRenk);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(txtMarka);
            panel1.Controls.Add(txtPlaka);
            panel1.Controls.Add(lblDurum);
            panel1.Controls.Add(lblUretimYili);
            panel1.Controls.Add(lblAracTipi);
            panel1.Controls.Add(lblYakitTipi);
            panel1.Controls.Add(lblVitesTipi);
            panel1.Controls.Add(lblRenk);
            panel1.Controls.Add(lblKilometre);
            panel1.Controls.Add(lblSonBakim);
            panel1.Controls.Add(lblGarantiDurumu);
            panel1.Controls.Add(lblSigortaTarihi);
            panel1.Controls.Add(lblGunlukFiyat);
            panel1.Controls.Add(lblModel);
            panel1.Controls.Add(lblMarka);
            panel1.Controls.Add(lblPlaka);
            panel1.Location = new Point(610, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 632);
            panel1.TabIndex = 7;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.MidnightBlue;
            btnTemizle.BackgroundImage = Properties.Resources.koyuButon;
            btnTemizle.BackgroundImageLayout = ImageLayout.Stretch;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTemizle.ForeColor = Color.Snow;
            btnTemizle.Location = new Point(314, 7);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(144, 88);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // cmbGarantiDurumu
            // 
            cmbGarantiDurumu.Font = new Font("Segoe UI", 10F);
            cmbGarantiDurumu.FormattingEnabled = true;
            cmbGarantiDurumu.Items.AddRange(new object[] { "Var", "Yok" });
            cmbGarantiDurumu.Location = new Point(229, 452);
            cmbGarantiDurumu.Name = "cmbGarantiDurumu";
            cmbGarantiDurumu.Size = new Size(190, 31);
            cmbGarantiDurumu.TabIndex = 29;
            // 
            // numKoltukSayisi
            // 
            numKoltukSayisi.Font = new Font("Segoe UI", 10F);
            numKoltukSayisi.Location = new Point(202, 291);
            numKoltukSayisi.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numKoltukSayisi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKoltukSayisi.Name = "numKoltukSayisi";
            numKoltukSayisi.Size = new Size(168, 30);
            numKoltukSayisi.TabIndex = 28;
            numKoltukSayisi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblKoltukSayisi
            // 
            lblKoltukSayisi.AutoSize = true;
            lblKoltukSayisi.Font = new Font("Stencil", 13.8F);
            lblKoltukSayisi.ForeColor = Color.Snow;
            lblKoltukSayisi.Location = new Point(2, 290);
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Size = new Size(194, 27);
            lblKoltukSayisi.TabIndex = 27;
            lblKoltukSayisi.Text = "Koltuk Sayisi :";
            // 
            // dtpSigortaTarihi
            // 
            dtpSigortaTarihi.Font = new Font("Segoe UI", 10F);
            dtpSigortaTarihi.Location = new Point(210, 489);
            dtpSigortaTarihi.Name = "dtpSigortaTarihi";
            dtpSigortaTarihi.Size = new Size(250, 30);
            dtpSigortaTarihi.TabIndex = 26;
            // 
            // dtpSonBakim
            // 
            dtpSonBakim.Font = new Font("Segoe UI", 10F);
            dtpSonBakim.Location = new Point(147, 409);
            dtpSonBakim.Name = "dtpSonBakim";
            dtpSonBakim.Size = new Size(250, 30);
            dtpSonBakim.TabIndex = 25;
            // 
            // numKilometre
            // 
            numKilometre.Font = new Font("Segoe UI", 10F);
            numKilometre.Location = new Point(157, 373);
            numKilometre.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numKilometre.Name = "numKilometre";
            numKilometre.Size = new Size(168, 30);
            numKilometre.TabIndex = 24;
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 10F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Müsait", "Rezerve", "Kirada", "Bakımda", "Diğer" });
            cmbDurum.Location = new Point(111, 532);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(213, 31);
            cmbDurum.TabIndex = 23;
            // 
            // cmbVitesTipi
            // 
            cmbVitesTipi.Font = new Font("Segoe UI", 10F);
            cmbVitesTipi.FormattingEnabled = true;
            cmbVitesTipi.Items.AddRange(new object[] { "Manuel", "Otomatik", "Yarı Otomatik", "CVT", "DSG", "Tiptronic", "Diğer" });
            cmbVitesTipi.Location = new Point(149, 250);
            cmbVitesTipi.Name = "cmbVitesTipi";
            cmbVitesTipi.Size = new Size(190, 31);
            cmbVitesTipi.TabIndex = 22;
            // 
            // cmbYakitTipi
            // 
            cmbYakitTipi.Font = new Font("Segoe UI", 10F);
            cmbYakitTipi.FormattingEnabled = true;
            cmbYakitTipi.Items.AddRange(new object[] { "Benzin", "Dizel", "Elektrik", "Hibrit", "LPG", "CNG", "Etanol", "Hidrojen", "Solar", "Diğer" });
            cmbYakitTipi.Location = new Point(149, 210);
            cmbYakitTipi.Name = "cmbYakitTipi";
            cmbYakitTipi.Size = new Size(190, 31);
            cmbYakitTipi.TabIndex = 21;
            // 
            // cmbAracTipi
            // 
            cmbAracTipi.Font = new Font("Segoe UI", 10F);
            cmbAracTipi.FormattingEnabled = true;
            cmbAracTipi.Items.AddRange(new object[] { "Sedan", "Hatchback", "Elektrikli", "SUV", "Pick-up", "Minibüs", "Coupe", "Cabriolet", "Roadster", "MPV", "Station Wagon" });
            cmbAracTipi.Location = new Point(143, 170);
            cmbAracTipi.Name = "cmbAracTipi";
            cmbAracTipi.Size = new Size(190, 31);
            cmbAracTipi.TabIndex = 20;
            // 
            // cmbUretimYili
            // 
            cmbUretimYili.Font = new Font("Segoe UI", 10F);
            cmbUretimYili.FormattingEnabled = true;
            cmbUretimYili.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            cmbUretimYili.Location = new Point(159, 130);
            cmbUretimYili.Name = "cmbUretimYili";
            cmbUretimYili.Size = new Size(190, 31);
            cmbUretimYili.TabIndex = 19;
            // 
            // txtGunlukFiyat
            // 
            txtGunlukFiyat.Font = new Font("Segoe UI", 10F);
            txtGunlukFiyat.Location = new Point(190, 572);
            txtGunlukFiyat.Name = "txtGunlukFiyat";
            txtGunlukFiyat.Size = new Size(192, 30);
            txtGunlukFiyat.TabIndex = 18;
            // 
            // txtRenk
            // 
            txtRenk.Font = new Font("Segoe UI", 10F);
            txtRenk.Location = new Point(94, 334);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(192, 30);
            txtRenk.TabIndex = 17;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 10F);
            txtModel.Location = new Point(106, 90);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(192, 30);
            txtModel.TabIndex = 16;
            // 
            // txtMarka
            // 
            txtMarka.Font = new Font("Segoe UI", 10F);
            txtMarka.Location = new Point(112, 50);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(192, 30);
            txtMarka.TabIndex = 15;
            // 
            // txtPlaka
            // 
            txtPlaka.Font = new Font("Segoe UI", 10F);
            txtPlaka.Location = new Point(101, 12);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(192, 30);
            txtPlaka.TabIndex = 14;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Stencil", 13.8F);
            lblDurum.ForeColor = Color.Snow;
            lblDurum.Location = new Point(-1, 532);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(106, 27);
            lblDurum.TabIndex = 13;
            lblDurum.Text = "Durum :";
            // 
            // lblUretimYili
            // 
            lblUretimYili.AutoSize = true;
            lblUretimYili.Font = new Font("Stencil", 13.8F);
            lblUretimYili.ForeColor = Color.Snow;
            lblUretimYili.Location = new Point(2, 130);
            lblUretimYili.Name = "lblUretimYili";
            lblUretimYili.Size = new Size(151, 27);
            lblUretimYili.TabIndex = 12;
            lblUretimYili.Text = "Üretim Yılı :";
            // 
            // lblAracTipi
            // 
            lblAracTipi.AutoSize = true;
            lblAracTipi.Font = new Font("Stencil", 13.8F);
            lblAracTipi.ForeColor = Color.Snow;
            lblAracTipi.Location = new Point(2, 170);
            lblAracTipi.Name = "lblAracTipi";
            lblAracTipi.Size = new Size(135, 27);
            lblAracTipi.TabIndex = 11;
            lblAracTipi.Text = "Araç Tipi :";
            // 
            // lblYakitTipi
            // 
            lblYakitTipi.AutoSize = true;
            lblYakitTipi.Font = new Font("Stencil", 13.8F);
            lblYakitTipi.ForeColor = Color.Snow;
            lblYakitTipi.Location = new Point(2, 210);
            lblYakitTipi.Name = "lblYakitTipi";
            lblYakitTipi.Size = new Size(141, 27);
            lblYakitTipi.TabIndex = 10;
            lblYakitTipi.Text = "Yakıt Tipi :";
            // 
            // lblVitesTipi
            // 
            lblVitesTipi.AutoSize = true;
            lblVitesTipi.Font = new Font("Stencil", 13.8F);
            lblVitesTipi.ForeColor = Color.Snow;
            lblVitesTipi.Location = new Point(2, 250);
            lblVitesTipi.Name = "lblVitesTipi";
            lblVitesTipi.Size = new Size(141, 27);
            lblVitesTipi.TabIndex = 9;
            lblVitesTipi.Text = "Vites Tipi :";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Font = new Font("Stencil", 13.8F);
            lblRenk.ForeColor = Color.Snow;
            lblRenk.Location = new Point(2, 334);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(86, 27);
            lblRenk.TabIndex = 8;
            lblRenk.Text = "Renk :";
            // 
            // lblKilometre
            // 
            lblKilometre.AutoSize = true;
            lblKilometre.Font = new Font("Stencil", 13.8F);
            lblKilometre.ForeColor = Color.Snow;
            lblKilometre.Location = new Point(-1, 372);
            lblKilometre.Name = "lblKilometre";
            lblKilometre.Size = new Size(152, 27);
            lblKilometre.TabIndex = 7;
            lblKilometre.Text = "Kilometre :";
            // 
            // lblSonBakim
            // 
            lblSonBakim.AutoSize = true;
            lblSonBakim.Font = new Font("Stencil", 13.8F);
            lblSonBakim.ForeColor = Color.Snow;
            lblSonBakim.Location = new Point(-1, 412);
            lblSonBakim.Name = "lblSonBakim";
            lblSonBakim.Size = new Size(142, 27);
            lblSonBakim.TabIndex = 6;
            lblSonBakim.Text = "Son Bakım :";
            // 
            // lblGarantiDurumu
            // 
            lblGarantiDurumu.AutoSize = true;
            lblGarantiDurumu.Font = new Font("Stencil", 13.8F);
            lblGarantiDurumu.ForeColor = Color.Snow;
            lblGarantiDurumu.Location = new Point(-1, 452);
            lblGarantiDurumu.Name = "lblGarantiDurumu";
            lblGarantiDurumu.Size = new Size(224, 27);
            lblGarantiDurumu.TabIndex = 5;
            lblGarantiDurumu.Text = "Garanti Durumu :";
            // 
            // lblSigortaTarihi
            // 
            lblSigortaTarihi.AutoSize = true;
            lblSigortaTarihi.Font = new Font("Stencil", 13.8F);
            lblSigortaTarihi.ForeColor = Color.Snow;
            lblSigortaTarihi.Location = new Point(-1, 492);
            lblSigortaTarihi.Name = "lblSigortaTarihi";
            lblSigortaTarihi.Size = new Size(205, 27);
            lblSigortaTarihi.TabIndex = 4;
            lblSigortaTarihi.Text = "Sigorta Tarihi :";
            // 
            // lblGunlukFiyat
            // 
            lblGunlukFiyat.AutoSize = true;
            lblGunlukFiyat.Font = new Font("Stencil", 13.8F);
            lblGunlukFiyat.ForeColor = Color.Snow;
            lblGunlukFiyat.Location = new Point(-1, 572);
            lblGunlukFiyat.Name = "lblGunlukFiyat";
            lblGunlukFiyat.Size = new Size(185, 27);
            lblGunlukFiyat.TabIndex = 3;
            lblGunlukFiyat.Text = "Günlük Fiyat :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Stencil", 13.8F);
            lblModel.ForeColor = Color.Snow;
            lblModel.Location = new Point(2, 90);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(98, 27);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model :";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Stencil", 13.8F);
            lblMarka.ForeColor = Color.Snow;
            lblMarka.Location = new Point(2, 50);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(104, 27);
            lblMarka.TabIndex = 1;
            lblMarka.Text = "Marka :";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new Font("Stencil", 13.8F);
            lblPlaka.ForeColor = Color.Snow;
            lblPlaka.Location = new Point(2, 10);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(97, 27);
            lblPlaka.TabIndex = 0;
            lblPlaka.Text = "Plaka :";
            // 
            // lblTarihUyarisi
            // 
            lblTarihUyarisi.AutoSize = true;
            lblTarihUyarisi.BackColor = Color.Snow;
            lblTarihUyarisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarihUyarisi.ForeColor = Color.Black;
            lblTarihUyarisi.Location = new Point(1087, 234);
            lblTarihUyarisi.Name = "lblTarihUyarisi";
            lblTarihUyarisi.Size = new Size(240, 69);
            lblTarihUyarisi.TabIndex = 37;
            lblTarihUyarisi.Text = "Tarih girişlerini yyyy-mm-dd\r\nformatında yapınız! \r\nÖrneğin : 2005-08-23\r\n";
            lblTarihUyarisi.Visible = false;
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
            pnlArama.ForeColor = SystemColors.ControlText;
            pnlArama.Location = new Point(1097, 307);
            pnlArama.Name = "pnlArama";
            pnlArama.Size = new Size(221, 191);
            pnlArama.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Goudy Stout", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(209, 27);
            label2.TabIndex = 12;
            label2.Text = "* Arama *";
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
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // AracGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Koyu_temaya_uygun__klasik_araba__yandan_ve_uzaktan_görünüm_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1331, 752);
            Controls.Add(lblTarihUyarisi);
            Controls.Add(pnlArama);
            Controls.Add(btnGuncelle);
            Controls.Add(panel1);
            Controls.Add(dgvAraclar);
            Controls.Add(lblAracGuncelle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AracGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Güncelle";
            Load += AracGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKoltukSayisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKilometre).EndInit();
            pnlArama.ResumeLayout(false);
            pnlArama.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAracGuncelle;
        private DataGridView dgvAraclar;
        private Button btnGuncelle;
        private Panel panel1;
        private Label lblUretimYili;
        private Label lblAracTipi;
        private Label lblYakitTipi;
        private Label lblVitesTipi;
        private Label lblRenk;
        private Label lblKilometre;
        private Label lblSonBakim;
        private Label lblGarantiDurumu;
        private Label lblSigortaTarihi;
        private Label lblGunlukFiyat;
        private Label lblModel;
        private Label lblMarka;
        private Label lblPlaka;
        private Label lblDurum;
        private TextBox txtModel;
        private TextBox txtMarka;
        private TextBox txtPlaka;
        private TextBox txtGunlukFiyat;
        private TextBox txtRenk;
        private NumericUpDown numKoltukSayisi;
        private Label lblKoltukSayisi;
        private DateTimePicker dtpSigortaTarihi;
        private DateTimePicker dtpSonBakim;
        private NumericUpDown numKilometre;
        private ComboBox cmbDurum;
        private ComboBox cmbVitesTipi;
        private ComboBox cmbYakitTipi;
        private ComboBox cmbAracTipi;
        private ComboBox cmbUretimYili;
        private ComboBox cmbGarantiDurumu;
        private Button btnTemizle;
        private Label lblTarihUyarisi;
        private Panel pnlArama;
        private Label label2;
        private Label lblKolon;
        private Label lblArama;
        private ComboBox cmbAramaKolonu;
        private TextBox txtArama;
    }
}
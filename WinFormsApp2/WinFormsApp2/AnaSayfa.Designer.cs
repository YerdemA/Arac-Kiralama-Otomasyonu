namespace WinFormsApp2
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            btnArac = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAracEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAracSil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAracGuncelle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAraclariListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnMusteri = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnMusteriEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnMusteriSil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnMusteriGuncelle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnMusterileriListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnKiralama = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnAracKirala = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnKiralamaGecmisi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnMuhasebe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnGelir = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnGider = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnMuhasebeGor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnDiger = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnOturumuKapat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnCikis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            lblSaat = new Label();
            lblTarih = new Label();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BackColor = Color.FromArgb(45, 45, 45);
            accordionControl1.Appearance.AccordionControl.ForeColor = Color.Snow;
            accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            accordionControl1.Dock = DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnArac, btnMusteri, btnKiralama, btnMuhasebe, btnDiger });
            accordionControl1.Location = new Point(0, 0);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.Size = new Size(212, 598);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnArac
            // 
            btnArac.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnAracEkle, btnAracSil, btnAracGuncelle, btnAraclariListele });
            btnArac.ImageOptions.Image = (Image)resources.GetObject("btnArac.ImageOptions.Image");
            btnArac.Name = "btnArac";
            btnArac.Text = "Araç";
            // 
            // btnAracEkle
            // 
            btnAracEkle.ImageOptions.Image = (Image)resources.GetObject("btnAracEkle.ImageOptions.Image");
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnAracEkle.Text = "Araç Ekle";
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // btnAracSil
            // 
            btnAracSil.ImageOptions.Image = (Image)resources.GetObject("btnAracSil.ImageOptions.Image");
            btnAracSil.Name = "btnAracSil";
            btnAracSil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnAracSil.Text = "Araç Sil";
            btnAracSil.Click += btnAracSil_Click;
            // 
            // btnAracGuncelle
            // 
            btnAracGuncelle.ImageOptions.Image = (Image)resources.GetObject("btnAracGuncelle.ImageOptions.Image");
            btnAracGuncelle.Name = "btnAracGuncelle";
            btnAracGuncelle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnAracGuncelle.Text = "Araç Güncelle";
            btnAracGuncelle.Click += btnAracGuncelle_Click;
            // 
            // btnAraclariListele
            // 
            btnAraclariListele.ImageOptions.Image = (Image)resources.GetObject("btnAraclariListele.ImageOptions.Image");
            btnAraclariListele.Name = "btnAraclariListele";
            btnAraclariListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnAraclariListele.Text = "Araçları Listele";
            btnAraclariListele.Click += btnAraclariListele_Click;
            // 
            // btnMusteri
            // 
            btnMusteri.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnMusteriEkle, btnMusteriSil, btnMusteriGuncelle, btnMusterileriListele });
            btnMusteri.ImageOptions.Image = (Image)resources.GetObject("btnMusteri.ImageOptions.Image");
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Text = "Müşteri";
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.ImageOptions.Image = (Image)resources.GetObject("btnMusteriEkle.ImageOptions.Image");
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.ImageOptions.Image = (Image)resources.GetObject("btnMusteriSil.ImageOptions.Image");
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnMusteriSil.Text = "Müşteri Sil";
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.ImageOptions.Image = (Image)resources.GetObject("btnMusteriGuncelle.ImageOptions.Image");
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnMusteriGuncelle.Text = "Müşteri Güncelle";
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnMusterileriListele
            // 
            btnMusterileriListele.ImageOptions.Image = (Image)resources.GetObject("btnMusterileriListele.ImageOptions.Image");
            btnMusterileriListele.Name = "btnMusterileriListele";
            btnMusterileriListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnMusterileriListele.Text = "Müşterileri Listele";
            btnMusterileriListele.Click += btnMusterileriListele_Click;
            // 
            // btnKiralama
            // 
            btnKiralama.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnAracKirala, btnKiralamaGecmisi });
            btnKiralama.ImageOptions.Image = (Image)resources.GetObject("btnKiralama.ImageOptions.Image");
            btnKiralama.Name = "btnKiralama";
            btnKiralama.Text = "Kiralama";
            // 
            // btnAracKirala
            // 
            btnAracKirala.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAracKirala.ImageOptions.SvgImage");
            btnAracKirala.Name = "btnAracKirala";
            btnAracKirala.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnAracKirala.Text = "Araç Kirala";
            btnAracKirala.Click += btnAracKirala_Click;
            // 
            // btnKiralamaGecmisi
            // 
            btnKiralamaGecmisi.ImageOptions.Image = (Image)resources.GetObject("btnKiralamaGecmisi.ImageOptions.Image");
            btnKiralamaGecmisi.Name = "btnKiralamaGecmisi";
            btnKiralamaGecmisi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnKiralamaGecmisi.Text = "Kiralama Geçmişi";
            btnKiralamaGecmisi.Click += btnKiralamaGecmisi_Click;
            // 
            // btnMuhasebe
            // 
            btnMuhasebe.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnGelir, btnGider, btnMuhasebeGor });
            btnMuhasebe.ImageOptions.Image = (Image)resources.GetObject("btnMuhasebe.ImageOptions.Image");
            btnMuhasebe.Name = "btnMuhasebe";
            btnMuhasebe.Text = "Muhasebe";
            // 
            // btnGelir
            // 
            btnGelir.ImageOptions.Image = (Image)resources.GetObject("btnGelir.ImageOptions.Image");
            btnGelir.Name = "btnGelir";
            btnGelir.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnGelir.Text = "Gelir Girişi";
            btnGelir.Click += btnGelir_Click;
            // 
            // btnGider
            // 
            btnGider.ImageOptions.Image = (Image)resources.GetObject("btnGider.ImageOptions.Image");
            btnGider.Name = "btnGider";
            btnGider.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnGider.Text = "Gider Girişi";
            btnGider.Click += btnGider_Click;
            // 
            // btnMuhasebeGor
            // 
            btnMuhasebeGor.ImageOptions.Image = (Image)resources.GetObject("btnMuhasebeGor.ImageOptions.Image");
            btnMuhasebeGor.Name = "btnMuhasebeGor";
            btnMuhasebeGor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnMuhasebeGor.Text = "Gelir-Gider Tablosu";
            btnMuhasebeGor.Click += btnMuhasebeGor_Click;
            // 
            // btnDiger
            // 
            btnDiger.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnOturumuKapat, btnCikis });
            btnDiger.Expanded = true;
            btnDiger.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDiger.ImageOptions.SvgImage");
            btnDiger.Name = "btnDiger";
            btnDiger.Text = "Diğer";
            // 
            // btnOturumuKapat
            // 
            btnOturumuKapat.ImageOptions.Image = (Image)resources.GetObject("btnOturumuKapat.ImageOptions.Image");
            btnOturumuKapat.Name = "btnOturumuKapat";
            btnOturumuKapat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnOturumuKapat.Text = "Oturumu Kapat";
            btnOturumuKapat.Click += btnOturumuKapat_Click;
            // 
            // btnCikis
            // 
            btnCikis.ImageOptions.Image = (Image)resources.GetObject("btnCikis.ImageOptions.Image");
            btnCikis.Name = "btnCikis";
            btnCikis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnCikis.Text = "Çıkış";
            btnCikis.Click += btnCikis_Click;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.BackColor = Color.Transparent;
            lblSaat.Font = new Font("Cooper Black", 20F);
            lblSaat.ForeColor = Color.Snow;
            lblSaat.Location = new Point(724, 48);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(193, 39);
            lblSaat.TabIndex = 2;
            lblSaat.Text = "15 : 42 : 38";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.BackColor = Color.Transparent;
            lblTarih.Font = new Font("Cooper Black", 20F);
            lblTarih.ForeColor = Color.Snow;
            lblTarih.Location = new Point(674, 9);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(243, 39);
            lblTarih.TabIndex = 3;
            lblTarih.Text = "05 Ocak 2025";
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.anaSarkaplan;
            ClientSize = new Size(917, 598);
            Controls.Add(lblTarih);
            Controls.Add(lblSaat);
            Controls.Add(accordionControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AnaSayfa";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kiralama Otomasyonu";
            Load += AnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnArac;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAracEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAracSil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAracGuncelle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAraclariListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMusteri;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMusteriEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMusteriSil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMusteriGuncelle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMusterileriListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKiralama;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAracKirala;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKiralamaGecmisi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDiger;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOturumuKapat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCikis;
        private Label lblSaat;
        private Label lblTarih;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMuhasebe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnGelir;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnGider;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMuhasebeGor;
    }
}
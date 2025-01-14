namespace WinFormsApp2
{
    partial class MuhasebeFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuhasebeFormu));
            lblBaslik = new Label();
            dgvMuhasebe = new DataGridView();
            cmbFiltre = new ComboBox();
            dtpBaslangicTarihi = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            btnFiltrele = new Button();
            btnSifirla = new Button();
            lblToplamGelir = new Label();
            lblToplamGider = new Label();
            lblNetKar = new Label();
            lblListelenecekler = new Label();
            label1 = new Label();
            label2 = new Label();
            gbSiralama = new GroupBox();
            rbStandart = new RadioButton();
            rbTarihY_E = new RadioButton();
            rbTarihE_Y = new RadioButton();
            rbTutarY_D = new RadioButton();
            rbTutarD_Y = new RadioButton();
            btnSil = new Button();
            btnGuncelle = new Button();
            pnlGuncelle = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            mtxtTarih = new MaskedTextBox();
            txtAciklama = new TextBox();
            txtTutar = new TextBox();
            cmbTur = new ComboBox();
            pnlFiltre = new Panel();
            cbFiltrePaneli = new CheckBox();
            cbGuncellePaneli = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvMuhasebe).BeginInit();
            gbSiralama.SuspendLayout();
            pnlGuncelle.SuspendLayout();
            pnlFiltre.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = Color.Transparent;
            lblBaslik.FlatStyle = FlatStyle.Flat;
            lblBaslik.Font = new Font("Gill Sans Ultra Bold Condensed", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBaslik.ForeColor = Color.Snow;
            lblBaslik.Location = new Point(330, 16);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(584, 68);
            lblBaslik.TabIndex = 3;
            lblBaslik.Text = "< Gelir - Gider Yönetimi >";
            // 
            // dgvMuhasebe
            // 
            dgvMuhasebe.BackgroundColor = Color.WhiteSmoke;
            dgvMuhasebe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuhasebe.Location = new Point(295, 97);
            dgvMuhasebe.Name = "dgvMuhasebe";
            dgvMuhasebe.RowHeadersWidth = 51;
            dgvMuhasebe.Size = new Size(584, 535);
            dgvMuhasebe.TabIndex = 4;
            // 
            // cmbFiltre
            // 
            cmbFiltre.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            cmbFiltre.FormattingEnabled = true;
            cmbFiltre.Location = new Point(8, 40);
            cmbFiltre.Name = "cmbFiltre";
            cmbFiltre.Size = new Size(246, 43);
            cmbFiltre.TabIndex = 5;
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Font = new Font("Segoe UI", 15F);
            dtpBaslangicTarihi.Location = new Point(8, 126);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(253, 41);
            dtpBaslangicTarihi.TabIndex = 6;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Font = new Font("Segoe UI", 15F);
            dtpBitisTarihi.Location = new Point(10, 213);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(251, 41);
            dtpBitisTarihi.TabIndex = 7;
            // 
            // btnFiltrele
            // 
            btnFiltrele.BackgroundImage = Properties.Resources.btnSil;
            btnFiltrele.FlatStyle = FlatStyle.Flat;
            btnFiltrele.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrele.ForeColor = Color.Snow;
            btnFiltrele.Location = new Point(40, 502);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(184, 62);
            btnFiltrele.TabIndex = 8;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.BackgroundImage = Properties.Resources.btnSil;
            btnSifirla.FlatStyle = FlatStyle.Flat;
            btnSifirla.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSifirla.ForeColor = Color.Snow;
            btnSifirla.Location = new Point(48, 571);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(168, 102);
            btnSifirla.TabIndex = 9;
            btnSifirla.Text = "Filtreleri Sifirla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.FlatStyle = FlatStyle.Flat;
            lblToplamGelir.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToplamGelir.Location = new Point(295, 661);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(203, 31);
            lblToplamGelir.TabIndex = 10;
            lblToplamGelir.Text = "Toplam Gelir :";
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.FlatStyle = FlatStyle.Flat;
            lblToplamGider.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToplamGider.Location = new Point(295, 702);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(208, 31);
            lblToplamGider.TabIndex = 11;
            lblToplamGider.Text = "Toplam Gider :";
            // 
            // lblNetKar
            // 
            lblNetKar.AutoSize = true;
            lblNetKar.FlatStyle = FlatStyle.Flat;
            lblNetKar.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNetKar.Location = new Point(708, 676);
            lblNetKar.Name = "lblNetKar";
            lblNetKar.Size = new Size(128, 31);
            lblNetKar.TabIndex = 12;
            lblNetKar.Text = "Net kar :";
            // 
            // lblListelenecekler
            // 
            lblListelenecekler.AutoSize = true;
            lblListelenecekler.BackColor = Color.Transparent;
            lblListelenecekler.FlatStyle = FlatStyle.Flat;
            lblListelenecekler.Font = new Font("Stencil", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListelenecekler.Location = new Point(8, 9);
            lblListelenecekler.Name = "lblListelenecekler";
            lblListelenecekler.Size = new Size(248, 30);
            lblListelenecekler.TabIndex = 13;
            lblListelenecekler.Text = "Listelenecekler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 95);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 14;
            label1.Text = "Baslangic Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Stencil", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 182);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 15;
            label2.Text = "Bitis Tarihi";
            // 
            // gbSiralama
            // 
            gbSiralama.Controls.Add(rbStandart);
            gbSiralama.Controls.Add(rbTarihY_E);
            gbSiralama.Controls.Add(rbTarihE_Y);
            gbSiralama.Controls.Add(rbTutarY_D);
            gbSiralama.Controls.Add(rbTutarD_Y);
            gbSiralama.Font = new Font("Gill Sans Ultra Bold Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSiralama.Location = new Point(8, 274);
            gbSiralama.Name = "gbSiralama";
            gbSiralama.Size = new Size(250, 214);
            gbSiralama.TabIndex = 16;
            gbSiralama.TabStop = false;
            gbSiralama.Text = "Sıralama Ölçütü";
            // 
            // rbStandart
            // 
            rbStandart.AutoSize = true;
            rbStandart.Font = new Font("Gill Sans Ultra Bold Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbStandart.Location = new Point(3, 175);
            rbStandart.Name = "rbStandart";
            rbStandart.Size = new Size(103, 30);
            rbStandart.TabIndex = 21;
            rbStandart.TabStop = true;
            rbStandart.Text = "Standart";
            rbStandart.UseVisualStyleBackColor = true;
            // 
            // rbTarihY_E
            // 
            rbTarihY_E.AutoSize = true;
            rbTarihY_E.Font = new Font("Gill Sans Ultra Bold Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbTarihY_E.Location = new Point(4, 139);
            rbTarihY_E.Name = "rbTarihY_E";
            rbTarihY_E.Size = new Size(214, 30);
            rbTarihY_E.TabIndex = 20;
            rbTarihY_E.TabStop = true;
            rbTarihY_E.Text = "Tarih - Yeniden eskiye";
            rbTarihY_E.UseVisualStyleBackColor = true;
            // 
            // rbTarihE_Y
            // 
            rbTarihE_Y.AutoSize = true;
            rbTarihE_Y.Font = new Font("Gill Sans Ultra Bold Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbTarihE_Y.Location = new Point(4, 103);
            rbTarihE_Y.Name = "rbTarihE_Y";
            rbTarihE_Y.Size = new Size(212, 30);
            rbTarihE_Y.TabIndex = 19;
            rbTarihE_Y.TabStop = true;
            rbTarihE_Y.Text = "Tarih - Eskiden yeniye";
            rbTarihE_Y.UseVisualStyleBackColor = true;
            // 
            // rbTutarY_D
            // 
            rbTutarY_D.AutoSize = true;
            rbTutarY_D.Font = new Font("Gill Sans Ultra Bold Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbTutarY_D.Location = new Point(4, 68);
            rbTutarY_D.Name = "rbTutarY_D";
            rbTutarY_D.Size = new Size(242, 30);
            rbTutarY_D.TabIndex = 18;
            rbTutarY_D.TabStop = true;
            rbTutarY_D.Text = "Tutar - Yüksekten düsüge";
            rbTutarY_D.UseVisualStyleBackColor = true;
            // 
            // rbTutarD_Y
            // 
            rbTutarD_Y.AutoSize = true;
            rbTutarD_Y.Font = new Font("Gill Sans Ultra Bold Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbTutarD_Y.Location = new Point(4, 32);
            rbTutarD_Y.Name = "rbTutarD_Y";
            rbTutarD_Y.Size = new Size(241, 30);
            rbTutarD_Y.TabIndex = 17;
            rbTutarD_Y.TabStop = true;
            rbTutarD_Y.Text = "Tutar - Düşükten yüksege";
            rbTutarD_Y.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = Properties.Resources.btnSil;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Stencil", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.Snow;
            btnSil.Location = new Point(920, 40);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(211, 100);
            btnSil.TabIndex = 17;
            btnSil.Text = "Tablodan Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImage = Properties.Resources.btnSil;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuncelle.ForeColor = Color.Snow;
            btnGuncelle.Location = new Point(53, 409);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(158, 66);
            btnGuncelle.TabIndex = 18;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // pnlGuncelle
            // 
            pnlGuncelle.BackColor = Color.LightSlateGray;
            pnlGuncelle.Controls.Add(label6);
            pnlGuncelle.Controls.Add(btnGuncelle);
            pnlGuncelle.Controls.Add(label5);
            pnlGuncelle.Controls.Add(label4);
            pnlGuncelle.Controls.Add(label3);
            pnlGuncelle.Controls.Add(mtxtTarih);
            pnlGuncelle.Controls.Add(txtAciklama);
            pnlGuncelle.Controls.Add(txtTutar);
            pnlGuncelle.Controls.Add(cmbTur);
            pnlGuncelle.Location = new Point(896, 186);
            pnlGuncelle.Name = "pnlGuncelle";
            pnlGuncelle.Size = new Size(250, 490);
            pnlGuncelle.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 328);
            label6.Name = "label6";
            label6.Size = new Size(84, 29);
            label6.TabIndex = 7;
            label6.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 184);
            label5.Name = "label5";
            label5.Size = new Size(135, 29);
            label5.TabIndex = 6;
            label5.Text = "Açıklama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(87, 29);
            label4.TabIndex = 5;
            label4.Text = "Tutar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 4;
            label3.Text = "Tür";
            // 
            // mtxtTarih
            // 
            mtxtTarih.Font = new Font("Segoe UI", 12F);
            mtxtTarih.Location = new Point(13, 360);
            mtxtTarih.Mask = "0000-00-00";
            mtxtTarih.Name = "mtxtTarih";
            mtxtTarih.Size = new Size(120, 34);
            mtxtTarih.TabIndex = 3;
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI", 12F);
            txtAciklama.Location = new Point(13, 216);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(212, 98);
            txtAciklama.TabIndex = 2;
            // 
            // txtTutar
            // 
            txtTutar.Font = new Font("Segoe UI", 12F);
            txtTutar.Location = new Point(13, 126);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(151, 34);
            txtTutar.TabIndex = 1;
            // 
            // cmbTur
            // 
            cmbTur.Font = new Font("Segoe UI", 12F);
            cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Gelir", "Gider" });
            cmbTur.Location = new Point(13, 41);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 36);
            cmbTur.TabIndex = 0;
            // 
            // pnlFiltre
            // 
            pnlFiltre.BackColor = Color.LightSlateGray;
            pnlFiltre.Controls.Add(gbSiralama);
            pnlFiltre.Controls.Add(cmbFiltre);
            pnlFiltre.Controls.Add(dtpBaslangicTarihi);
            pnlFiltre.Controls.Add(dtpBitisTarihi);
            pnlFiltre.Controls.Add(label2);
            pnlFiltre.Controls.Add(btnFiltrele);
            pnlFiltre.Controls.Add(label1);
            pnlFiltre.Controls.Add(btnSifirla);
            pnlFiltre.Controls.Add(lblListelenecekler);
            pnlFiltre.Location = new Point(4, 55);
            pnlFiltre.Name = "pnlFiltre";
            pnlFiltre.Size = new Size(280, 691);
            pnlFiltre.TabIndex = 20;
            // 
            // cbFiltrePaneli
            // 
            cbFiltrePaneli.AutoSize = true;
            cbFiltrePaneli.Checked = true;
            cbFiltrePaneli.CheckState = CheckState.Checked;
            cbFiltrePaneli.FlatStyle = FlatStyle.Flat;
            cbFiltrePaneli.Font = new Font("Cooper Black", 10F);
            cbFiltrePaneli.Location = new Point(16, 16);
            cbFiltrePaneli.Name = "cbFiltrePaneli";
            cbFiltrePaneli.Size = new Size(134, 24);
            cbFiltrePaneli.TabIndex = 21;
            cbFiltrePaneli.Text = "Filtre Paneli";
            cbFiltrePaneli.UseVisualStyleBackColor = true;
            cbFiltrePaneli.CheckedChanged += cbFiltrePaneli_CheckedChanged;
            // 
            // cbGuncellePaneli
            // 
            cbGuncellePaneli.AutoSize = true;
            cbGuncellePaneli.Checked = true;
            cbGuncellePaneli.CheckState = CheckState.Checked;
            cbGuncellePaneli.FlatStyle = FlatStyle.Flat;
            cbGuncellePaneli.Font = new Font("Cooper Black", 10F);
            cbGuncellePaneli.Location = new Point(935, 156);
            cbGuncellePaneli.Name = "cbGuncellePaneli";
            cbGuncellePaneli.Size = new Size(186, 24);
            cbGuncellePaneli.TabIndex = 22;
            cbGuncellePaneli.Text = "Güncelleme Paneli";
            cbGuncellePaneli.UseVisualStyleBackColor = true;
            cbGuncellePaneli.CheckedChanged += cbGuncellePaneli_CheckedChanged;
            // 
            // MuhasebeFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1173, 765);
            Controls.Add(cbGuncellePaneli);
            Controls.Add(cbFiltrePaneli);
            Controls.Add(pnlGuncelle);
            Controls.Add(btnSil);
            Controls.Add(lblNetKar);
            Controls.Add(lblToplamGider);
            Controls.Add(lblToplamGelir);
            Controls.Add(dgvMuhasebe);
            Controls.Add(lblBaslik);
            Controls.Add(pnlFiltre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MuhasebeFormu";
            Text = "Muhasebe";
            Load += MuhasebeFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMuhasebe).EndInit();
            gbSiralama.ResumeLayout(false);
            gbSiralama.PerformLayout();
            pnlGuncelle.ResumeLayout(false);
            pnlGuncelle.PerformLayout();
            pnlFiltre.ResumeLayout(false);
            pnlFiltre.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private DataGridView dgvMuhasebe;
        private ComboBox cmbFiltre;
        private DateTimePicker dtpBaslangicTarihi;
        private DateTimePicker dtpBitisTarihi;
        private Button btnFiltrele;
        private Button btnSifirla;
        private Label lblToplamGelir;
        private Label lblToplamGider;
        private Label lblNetKar;
        private Label lblListelenecekler;
        private Label label1;
        private Label label2;
        private GroupBox gbSiralama;
        private RadioButton rbTarihE_Y;
        private RadioButton rbTutarY_D;
        private RadioButton rbTutarD_Y;
        private RadioButton rbTarihY_E;
        private RadioButton rbStandart;
        private Button btnSil;
        private Button btnGuncelle;
        private Panel pnlGuncelle;
        private MaskedTextBox mtxtTarih;
        private TextBox txtAciklama;
        private TextBox txtTutar;
        private ComboBox cmbTur;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel pnlFiltre;
        private CheckBox cbFiltrePaneli;
        private CheckBox cbGuncellePaneli;
    }
}
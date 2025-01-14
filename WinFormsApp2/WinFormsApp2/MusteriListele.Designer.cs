namespace WinFormsApp2
{
    partial class MusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListele));
            lblMusteriSil = new Label();
            dgvMusteriler = new DataGridView();
            btnListele = new Button();
            pictureBox1 = new PictureBox();
            Sırala = new ListBox();
            rdIdK_B = new RadioButton();
            rdIdB_K = new RadioButton();
            lblTarihUyarisi = new Label();
            pnlArama = new Panel();
            label1 = new Label();
            lblKolon = new Label();
            lblArama = new Label();
            cmbAramaKolonu = new ComboBox();
            txtArama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlArama.SuspendLayout();
            SuspendLayout();
            // 
            // lblMusteriSil
            // 
            lblMusteriSil.AutoSize = true;
            lblMusteriSil.BackColor = Color.Transparent;
            lblMusteriSil.Font = new Font("Goudy Stout", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusteriSil.ForeColor = Color.Snow;
            lblMusteriSil.Location = new Point(142, 20);
            lblMusteriSil.Name = "lblMusteriSil";
            lblMusteriSil.Size = new Size(665, 58);
            lblMusteriSil.TabIndex = 3;
            lblMusteriSil.Text = "< Musteriler >";
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.BackgroundColor = Color.Silver;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(12, 97);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(721, 578);
            dgvMusteriler.TabIndex = 7;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.Black;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Cooper Black", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListele.ForeColor = Color.Snow;
            btnListele.Location = new Point(815, 146);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(174, 120);
            btnListele.TabIndex = 8;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(828, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Sırala
            // 
            Sırala.BackColor = Color.Black;
            Sırala.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Sırala.ForeColor = Color.Snow;
            Sırala.FormattingEnabled = true;
            Sırala.Location = new Point(799, 272);
            Sırala.Name = "Sırala";
            Sırala.Size = new Size(208, 104);
            Sırala.TabIndex = 10;
            // 
            // rdIdK_B
            // 
            rdIdK_B.AutoSize = true;
            rdIdK_B.BackColor = Color.Black;
            rdIdK_B.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdIdK_B.ForeColor = Color.Snow;
            rdIdK_B.Location = new Point(806, 305);
            rdIdK_B.Name = "rdIdK_B";
            rdIdK_B.Size = new Size(183, 24);
            rdIdK_B.TabIndex = 11;
            rdIdK_B.TabStop = true;
            rdIdK_B.Text = "ID - Küçükten Büyüğe";
            rdIdK_B.UseVisualStyleBackColor = false;
            // 
            // rdIdB_K
            // 
            rdIdB_K.AutoSize = true;
            rdIdB_K.BackColor = Color.Black;
            rdIdB_K.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdIdB_K.ForeColor = Color.Snow;
            rdIdB_K.Location = new Point(806, 335);
            rdIdB_K.Name = "rdIdB_K";
            rdIdB_K.Size = new Size(183, 24);
            rdIdB_K.TabIndex = 12;
            rdIdB_K.TabStop = true;
            rdIdB_K.Text = "ID - Büyükten Küçüğe";
            rdIdB_K.UseVisualStyleBackColor = false;
            // 
            // lblTarihUyarisi
            // 
            lblTarihUyarisi.AutoSize = true;
            lblTarihUyarisi.BackColor = Color.DarkRed;
            lblTarihUyarisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarihUyarisi.ForeColor = Color.Snow;
            lblTarihUyarisi.Location = new Point(812, 586);
            lblTarihUyarisi.Name = "lblTarihUyarisi";
            lblTarihUyarisi.Size = new Size(184, 92);
            lblTarihUyarisi.TabIndex = 17;
            lblTarihUyarisi.Text = "Tarih girişini \r\nyyyy-mm-dd\r\nformatında yapınız! \r\nÖrneğin : 2005-08-23\r\n";
            lblTarihUyarisi.Visible = false;
            // 
            // pnlArama
            // 
            pnlArama.BackColor = Color.Black;
            pnlArama.Controls.Add(label1);
            pnlArama.Controls.Add(lblKolon);
            pnlArama.Controls.Add(lblArama);
            pnlArama.Controls.Add(cmbAramaKolonu);
            pnlArama.Controls.Add(txtArama);
            pnlArama.Location = new Point(794, 392);
            pnlArama.Name = "pnlArama";
            pnlArama.Size = new Size(221, 191);
            pnlArama.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Goudy Stout", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 11);
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
            cmbAramaKolonu.Items.AddRange(new object[] { "Ad", "Soyad", "Tc Kimlik Numarası", "Telefon Numarası", "E-Mail", "Doğum Tarihi" });
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
            // MusteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MusteriBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1063, 702);
            Controls.Add(lblTarihUyarisi);
            Controls.Add(pnlArama);
            Controls.Add(rdIdB_K);
            Controls.Add(rdIdK_B);
            Controls.Add(Sırala);
            Controls.Add(btnListele);
            Controls.Add(dgvMusteriler);
            Controls.Add(lblMusteriSil);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MusteriListele";
            Text = "Müşteriler";
            Load += MusteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlArama.ResumeLayout(false);
            pnlArama.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMusteriSil;
        private DataGridView dgvMusteriler;
        private Button btnListele;
        private PictureBox pictureBox1;
        private ListBox Sırala;
        private RadioButton rdIdK_B;
        private RadioButton rdIdB_K;
        private Label lblTarihUyarisi;
        private Panel pnlArama;
        private Label label1;
        private Label lblKolon;
        private Label lblArama;
        private ComboBox cmbAramaKolonu;
        private TextBox txtArama;
    }
}
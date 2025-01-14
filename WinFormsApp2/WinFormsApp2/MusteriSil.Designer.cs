namespace WinFormsApp2
{
    partial class MusteriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSil));
            dgvMusteriler = new DataGridView();
            lblMusteriSil = new Label();
            btnSil = new Button();
            pictureBox1 = new PictureBox();
            rbIdB_K = new RadioButton();
            rbIdK_B = new RadioButton();
            Sırala = new ListBox();
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
            // dgvMusteriler
            // 
            dgvMusteriler.BackgroundColor = Color.Silver;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(12, 135);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(651, 555);
            dgvMusteriler.TabIndex = 0;
            // 
            // lblMusteriSil
            // 
            lblMusteriSil.AutoSize = true;
            lblMusteriSil.BackColor = Color.Transparent;
            lblMusteriSil.Font = new Font("Goudy Stout", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusteriSil.ForeColor = Color.Snow;
            lblMusteriSil.Location = new Point(73, 32);
            lblMusteriSil.Name = "lblMusteriSil";
            lblMusteriSil.Size = new Size(660, 58);
            lblMusteriSil.TabIndex = 1;
            lblMusteriSil.Text = "< Musteri Sil >";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Black;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Cooper Black", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.Snow;
            btnSil.Location = new Point(744, 134);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(166, 120);
            btnSil.TabIndex = 3;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(757, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // rbIdB_K
            // 
            rbIdB_K.AutoSize = true;
            rbIdB_K.BackColor = Color.Black;
            rbIdB_K.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbIdB_K.ForeColor = Color.Snow;
            rbIdB_K.Location = new Point(731, 325);
            rbIdB_K.Name = "rbIdB_K";
            rbIdB_K.Size = new Size(183, 24);
            rbIdB_K.TabIndex = 15;
            rbIdB_K.Text = "ID - Büyükten Küçüğe";
            rbIdB_K.UseVisualStyleBackColor = false;
            rbIdB_K.CheckedChanged += rbIdB_K_CheckedChanged;
            // 
            // rbIdK_B
            // 
            rbIdK_B.AutoSize = true;
            rbIdK_B.BackColor = Color.Black;
            rbIdK_B.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbIdK_B.ForeColor = Color.Snow;
            rbIdK_B.Location = new Point(731, 295);
            rbIdK_B.Name = "rbIdK_B";
            rbIdK_B.Size = new Size(183, 24);
            rbIdK_B.TabIndex = 14;
            rbIdK_B.Text = "ID - Küçükten Büyüğe";
            rbIdK_B.UseVisualStyleBackColor = false;
            rbIdK_B.CheckedChanged += rbIdK_B_CheckedChanged;
            // 
            // Sırala
            // 
            Sırala.BackColor = Color.Black;
            Sırala.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Sırala.ForeColor = Color.Snow;
            Sırala.FormattingEnabled = true;
            Sırala.Location = new Point(724, 262);
            Sırala.Name = "Sırala";
            Sırala.Size = new Size(208, 104);
            Sırala.TabIndex = 13;
            // 
            // lblTarihUyarisi
            // 
            lblTarihUyarisi.AutoSize = true;
            lblTarihUyarisi.BackColor = Color.DarkRed;
            lblTarihUyarisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarihUyarisi.ForeColor = Color.Snow;
            lblTarihUyarisi.Location = new Point(737, 571);
            lblTarihUyarisi.Name = "lblTarihUyarisi";
            lblTarihUyarisi.Size = new Size(184, 92);
            lblTarihUyarisi.TabIndex = 19;
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
            pnlArama.Location = new Point(719, 386);
            pnlArama.Name = "pnlArama";
            pnlArama.Size = new Size(221, 191);
            pnlArama.TabIndex = 18;
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
            // MusteriSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MusteriBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 702);
            Controls.Add(lblTarihUyarisi);
            Controls.Add(pnlArama);
            Controls.Add(rbIdB_K);
            Controls.Add(rbIdK_B);
            Controls.Add(Sırala);
            Controls.Add(btnSil);
            Controls.Add(lblMusteriSil);
            Controls.Add(dgvMusteriler);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MusteriSil";
            Text = "Müşteri Sil";
            Load += MusteriSil_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlArama.ResumeLayout(false);
            pnlArama.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMusteriler;
        private Label lblMusteriSil;
        private Button btnSil;
        private PictureBox pictureBox1;
        private RadioButton rbIdB_K;
        private RadioButton rbIdK_B;
        private ListBox Sırala;
        private Label lblTarihUyarisi;
        private Panel pnlArama;
        private Label label1;
        private Label lblKolon;
        private Label lblArama;
        private ComboBox cmbAramaKolonu;
        private TextBox txtArama;
    }
}
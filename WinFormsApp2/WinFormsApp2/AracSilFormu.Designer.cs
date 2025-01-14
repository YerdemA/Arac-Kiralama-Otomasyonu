namespace WinFormsApp2
{
    partial class AracSilFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracSilFormu));
            dgvAraclar = new DataGridView();
            btnSil = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTarihUyarisi = new Label();
            pnlArama = new Panel();
            label2 = new Label();
            lblKolon = new Label();
            lblArama = new Label();
            cmbAramaKolonu = new ComboBox();
            txtArama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlArama.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAraclar
            // 
            dgvAraclar.BackgroundColor = Color.WhiteSmoke;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(171, 91);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.RowHeadersWidth = 51;
            dgvAraclar.Size = new Size(803, 585);
            dgvAraclar.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.MidnightBlue;
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Wide Latin", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.Snow;
            btnSil.Location = new Point(1043, 137);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(139, 130);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Goudy Stout", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(592, 68);
            label1.TabIndex = 2;
            label1.Text = "< Araç Sil >";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.klasAraba;
            pictureBox1.Location = new Point(1048, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // lblTarihUyarisi
            // 
            lblTarihUyarisi.AutoSize = true;
            lblTarihUyarisi.BackColor = Color.MidnightBlue;
            lblTarihUyarisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarihUyarisi.ForeColor = Color.Snow;
            lblTarihUyarisi.Location = new Point(980, 338);
            lblTarihUyarisi.Name = "lblTarihUyarisi";
            lblTarihUyarisi.Size = new Size(240, 69);
            lblTarihUyarisi.TabIndex = 35;
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
            pnlArama.Location = new Point(990, 409);
            pnlArama.Name = "pnlArama";
            pnlArama.Size = new Size(221, 191);
            pnlArama.TabIndex = 34;
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
            // AracSilFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.silForm;
            ClientSize = new Size(1228, 740);
            Controls.Add(lblTarihUyarisi);
            Controls.Add(pnlArama);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(dgvAraclar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AracSilFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Sil";
            Load += AracSilFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlArama.ResumeLayout(false);
            pnlArama.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAraclar;
        private Button btnSil;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblTarihUyarisi;
        private Panel pnlArama;
        private Label label2;
        private Label lblKolon;
        private Label lblArama;
        private ComboBox cmbAramaKolonu;
        private TextBox txtArama;
    }
}
namespace WinFormsApp2
{
    partial class GelirFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirFormu));
            lblBaslik = new Label();
            txtTutar = new TextBox();
            panel1 = new Panel();
            dtpTarih = new DateTimePicker();
            lblTarihBilgisi = new Label();
            lblAciklama = new Label();
            lblTutar = new Label();
            txtAciklama = new TextBox();
            btnGir = new Button();
            pictureBox1 = new PictureBox();
            lblTarih = new Label();
            lblSaat = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = Color.Transparent;
            lblBaslik.Font = new Font("Gill Sans Ultra Bold Condensed", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBaslik.ForeColor = Color.Black;
            lblBaslik.Location = new Point(203, 18);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(392, 91);
            lblBaslik.TabIndex = 2;
            lblBaslik.Text = "< Gelir Gir >";
            // 
            // txtTutar
            // 
            txtTutar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtTutar.Location = new Point(162, 24);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(228, 52);
            txtTutar.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dtpTarih);
            panel1.Controls.Add(lblTarihBilgisi);
            panel1.Controls.Add(lblAciklama);
            panel1.Controls.Add(lblTutar);
            panel1.Controls.Add(txtAciklama);
            panel1.Controls.Add(txtTutar);
            panel1.Location = new Point(12, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 416);
            panel1.TabIndex = 4;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 15F);
            dtpTarih.Location = new Point(161, 99);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(229, 41);
            dtpTarih.TabIndex = 8;
            // 
            // lblTarihBilgisi
            // 
            lblTarihBilgisi.AutoSize = true;
            lblTarihBilgisi.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarihBilgisi.Location = new Point(23, 100);
            lblTarihBilgisi.Name = "lblTarihBilgisi";
            lblTarihBilgisi.Size = new Size(132, 42);
            lblTarihBilgisi.TabIndex = 7;
            lblTarihBilgisi.Text = "Tarih :";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAciklama.Location = new Point(23, 170);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(184, 42);
            lblAciklama.TabIndex = 6;
            lblAciklama.Text = "Açıklama";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutar.Location = new Point(23, 30);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(133, 42);
            lblTutar.TabIndex = 5;
            lblTutar.Text = "Tutar :";
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtAciklama.Location = new Point(23, 209);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(380, 180);
            txtAciklama.TabIndex = 4;
            // 
            // btnGir
            // 
            btnGir.BackColor = Color.SeaGreen;
            btnGir.BackgroundImageLayout = ImageLayout.None;
            btnGir.FlatStyle = FlatStyle.Flat;
            btnGir.Font = new Font("Stencil", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGir.ForeColor = Color.Snow;
            btnGir.ImageAlign = ContentAlignment.MiddleLeft;
            btnGir.Location = new Point(612, 366);
            btnGir.Name = "btnGir";
            btnGir.Size = new Size(150, 151);
            btnGir.TabIndex = 5;
            btnGir.Text = "Gir";
            btnGir.UseVisualStyleBackColor = false;
            btnGir.Click += btnGir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.elPara;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(467, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 151);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.BackColor = Color.Transparent;
            lblTarih.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTarih.ForeColor = Color.Black;
            lblTarih.Location = new Point(533, 154);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(141, 35);
            lblTarih.TabIndex = 12;
            lblTarih.Text = "12.01.2025";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.BackColor = Color.Transparent;
            lblSaat.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSaat.ForeColor = Color.Black;
            lblSaat.Location = new Point(616, 206);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(78, 35);
            lblSaat.TabIndex = 11;
            lblSaat.Text = "03:14";
            // 
            // GelirFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(786, 566);
            Controls.Add(lblTarih);
            Controls.Add(lblSaat);
            Controls.Add(btnGir);
            Controls.Add(panel1);
            Controls.Add(lblBaslik);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GelirFormu";
            Text = "Gelir";
            Load += GelirFormu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private TextBox txtTutar;
        private Panel panel1;
        private DateTimePicker dtpTarih;
        private Label lblTarihBilgisi;
        private Label lblAciklama;
        private Label lblTutar;
        private TextBox txtAciklama;
        private Button btnGir;
        private PictureBox pictureBox1;
        private Label lblTarih;
        private Label lblSaat;
    }
}
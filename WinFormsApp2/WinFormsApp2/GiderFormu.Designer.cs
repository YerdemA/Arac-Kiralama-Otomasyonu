namespace WinFormsApp2
{
    partial class GiderFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderFormu));
            btnGir = new Button();
            panel1 = new Panel();
            dtpTarih = new DateTimePicker();
            lblTArihBilgisi = new Label();
            lblAciklama = new Label();
            lblTutar = new Label();
            txtAciklama = new TextBox();
            txtTutar = new TextBox();
            lblBaslik = new Label();
            lblSaat = new Label();
            lblTarih = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGir
            // 
            btnGir.BackColor = Color.DarkRed;
            btnGir.FlatStyle = FlatStyle.Flat;
            btnGir.Font = new Font("Stencil", 34F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGir.ForeColor = Color.Snow;
            btnGir.Location = new Point(584, 309);
            btnGir.Name = "btnGir";
            btnGir.Size = new Size(150, 150);
            btnGir.TabIndex = 8;
            btnGir.Text = "Gir";
            btnGir.UseVisualStyleBackColor = false;
            btnGir.Click += btnGir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(dtpTarih);
            panel1.Controls.Add(lblTArihBilgisi);
            panel1.Controls.Add(lblAciklama);
            panel1.Controls.Add(lblTutar);
            panel1.Controls.Add(txtAciklama);
            panel1.Controls.Add(txtTutar);
            panel1.Location = new Point(51, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 416);
            panel1.TabIndex = 7;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 15F);
            dtpTarih.Location = new Point(161, 99);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(229, 41);
            dtpTarih.TabIndex = 8;
            // 
            // lblTArihBilgisi
            // 
            lblTArihBilgisi.AutoSize = true;
            lblTArihBilgisi.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTArihBilgisi.Location = new Point(23, 100);
            lblTArihBilgisi.Name = "lblTArihBilgisi";
            lblTArihBilgisi.Size = new Size(132, 42);
            lblTArihBilgisi.TabIndex = 7;
            lblTArihBilgisi.Text = "Tarih :";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAciklama.Location = new Point(23, 166);
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
            // txtTutar
            // 
            txtTutar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtTutar.Location = new Point(162, 24);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(228, 52);
            txtTutar.TabIndex = 3;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = Color.Transparent;
            lblBaslik.Font = new Font("Gill Sans Ultra Bold Condensed", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBaslik.ForeColor = Color.Black;
            lblBaslik.Location = new Point(212, 23);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(364, 80);
            lblBaslik.TabIndex = 6;
            lblBaslik.Text = "< Gider Gir >";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.BackColor = Color.Transparent;
            lblSaat.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSaat.ForeColor = Color.Black;
            lblSaat.Location = new Point(635, 181);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(78, 35);
            lblSaat.TabIndex = 9;
            lblSaat.Text = "03:14";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.BackColor = Color.Transparent;
            lblTarih.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTarih.ForeColor = Color.Black;
            lblTarih.Location = new Point(552, 129);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(141, 35);
            lblTarih.TabIndex = 10;
            lblTarih.Text = "12.01.2025";
            // 
            // GiderFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 553);
            Controls.Add(lblTarih);
            Controls.Add(lblSaat);
            Controls.Add(btnGir);
            Controls.Add(panel1);
            Controls.Add(lblBaslik);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GiderFormu";
            Text = "Gider";
            Load += GiderFormu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGir;
        private Panel panel1;
        private DateTimePicker dtpTarih;
        private Label lblTArihBilgisi;
        private Label lblAciklama;
        private Label lblTutar;
        private TextBox txtAciklama;
        private TextBox txtTutar;
        private Label lblBaslik;
        private Label lblSaat;
        private Label lblTarih;
    }
}
namespace WinFormsApp2
{
    partial class KiralamaGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralamaGecmisi));
            lblMusteriSil = new Label();
            dgvKiralamaGecmisi = new DataGridView();
            gbSiralama = new GroupBox();
            rbToplamUcretArtan = new RadioButton();
            rbToplamUcretAzalan = new RadioButton();
            rbGunlukUcretArtan = new RadioButton();
            rbGunlukUcretAzalan = new RadioButton();
            rbTarihY_E = new RadioButton();
            rbTarihE_Y = new RadioButton();
            btnGoster = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKiralamaGecmisi).BeginInit();
            gbSiralama.SuspendLayout();
            SuspendLayout();
            // 
            // lblMusteriSil
            // 
            lblMusteriSil.AutoSize = true;
            lblMusteriSil.BackColor = Color.Transparent;
            lblMusteriSil.Font = new Font("Goudy Stout", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusteriSil.ForeColor = Color.Snow;
            lblMusteriSil.Location = new Point(12, 13);
            lblMusteriSil.Name = "lblMusteriSil";
            lblMusteriSil.Size = new Size(943, 58);
            lblMusteriSil.TabIndex = 10;
            lblMusteriSil.Text = "< KIRALAMA GECMISI >";
            // 
            // dgvKiralamaGecmisi
            // 
            dgvKiralamaGecmisi.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvKiralamaGecmisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKiralamaGecmisi.Location = new Point(12, 92);
            dgvKiralamaGecmisi.Name = "dgvKiralamaGecmisi";
            dgvKiralamaGecmisi.RowHeadersWidth = 51;
            dgvKiralamaGecmisi.Size = new Size(607, 517);
            dgvKiralamaGecmisi.TabIndex = 11;
            // 
            // gbSiralama
            // 
            gbSiralama.BackColor = Color.Transparent;
            gbSiralama.Controls.Add(rbToplamUcretArtan);
            gbSiralama.Controls.Add(rbToplamUcretAzalan);
            gbSiralama.Controls.Add(rbGunlukUcretArtan);
            gbSiralama.Controls.Add(rbGunlukUcretAzalan);
            gbSiralama.Controls.Add(rbTarihY_E);
            gbSiralama.Controls.Add(rbTarihE_Y);
            gbSiralama.FlatStyle = FlatStyle.Flat;
            gbSiralama.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            gbSiralama.ForeColor = Color.Snow;
            gbSiralama.Location = new Point(777, 92);
            gbSiralama.Name = "gbSiralama";
            gbSiralama.Size = new Size(250, 262);
            gbSiralama.TabIndex = 12;
            gbSiralama.TabStop = false;
            gbSiralama.Text = "Sıralama";
            // 
            // rbToplamUcretArtan
            // 
            rbToplamUcretArtan.AutoSize = true;
            rbToplamUcretArtan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbToplamUcretArtan.Location = new Point(11, 187);
            rbToplamUcretArtan.Name = "rbToplamUcretArtan";
            rbToplamUcretArtan.Size = new Size(220, 29);
            rbToplamUcretArtan.TabIndex = 5;
            rbToplamUcretArtan.TabStop = true;
            rbToplamUcretArtan.Text = "Toplam Ücret - Artan";
            rbToplamUcretArtan.UseVisualStyleBackColor = true;
            // 
            // rbToplamUcretAzalan
            // 
            rbToplamUcretAzalan.AutoSize = true;
            rbToplamUcretAzalan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbToplamUcretAzalan.Location = new Point(11, 225);
            rbToplamUcretAzalan.Name = "rbToplamUcretAzalan";
            rbToplamUcretAzalan.Size = new Size(228, 29);
            rbToplamUcretAzalan.TabIndex = 4;
            rbToplamUcretAzalan.TabStop = true;
            rbToplamUcretAzalan.Text = "Toplam Ücret - Azalan";
            rbToplamUcretAzalan.UseVisualStyleBackColor = true;
            // 
            // rbGunlukUcretArtan
            // 
            rbGunlukUcretArtan.AutoSize = true;
            rbGunlukUcretArtan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbGunlukUcretArtan.Location = new Point(11, 111);
            rbGunlukUcretArtan.Name = "rbGunlukUcretArtan";
            rbGunlukUcretArtan.Size = new Size(221, 29);
            rbGunlukUcretArtan.TabIndex = 3;
            rbGunlukUcretArtan.TabStop = true;
            rbGunlukUcretArtan.Text = "Günlük Ücret - Artan";
            rbGunlukUcretArtan.UseVisualStyleBackColor = true;
            // 
            // rbGunlukUcretAzalan
            // 
            rbGunlukUcretAzalan.AutoSize = true;
            rbGunlukUcretAzalan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbGunlukUcretAzalan.Location = new Point(11, 149);
            rbGunlukUcretAzalan.Name = "rbGunlukUcretAzalan";
            rbGunlukUcretAzalan.Size = new Size(229, 29);
            rbGunlukUcretAzalan.TabIndex = 2;
            rbGunlukUcretAzalan.TabStop = true;
            rbGunlukUcretAzalan.Text = "Günlük Ücret - Azalan";
            rbGunlukUcretAzalan.UseVisualStyleBackColor = true;
            // 
            // rbTarihY_E
            // 
            rbTarihY_E.AutoSize = true;
            rbTarihY_E.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbTarihY_E.Location = new Point(11, 35);
            rbTarihY_E.Name = "rbTarihY_E";
            rbTarihY_E.Size = new Size(224, 29);
            rbTarihY_E.TabIndex = 1;
            rbTarihY_E.TabStop = true;
            rbTarihY_E.Text = "Tarih - Yeniden Eskiye";
            rbTarihY_E.UseVisualStyleBackColor = true;
            // 
            // rbTarihE_Y
            // 
            rbTarihE_Y.AutoSize = true;
            rbTarihE_Y.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbTarihE_Y.Location = new Point(11, 73);
            rbTarihE_Y.Name = "rbTarihE_Y";
            rbTarihE_Y.Size = new Size(224, 29);
            rbTarihE_Y.TabIndex = 0;
            rbTarihE_Y.TabStop = true;
            rbTarihE_Y.Text = "Tarih - Eskiden Yeniye";
            rbTarihE_Y.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            btnGoster.BackColor = Color.FromArgb(0, 0, 64);
            btnGoster.FlatStyle = FlatStyle.Flat;
            btnGoster.Font = new Font("Segoe UI", 12F);
            btnGoster.ForeColor = Color.Snow;
            btnGoster.Location = new Point(777, 365);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(250, 42);
            btnGoster.TabIndex = 13;
            btnGoster.Text = "Göster";
            btnGoster.TextAlign = ContentAlignment.TopCenter;
            btnGoster.UseVisualStyleBackColor = false;
            btnGoster.Click += btnGoster_Click;
            // 
            // KiralamaGecmisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1039, 621);
            Controls.Add(btnGoster);
            Controls.Add(gbSiralama);
            Controls.Add(dgvKiralamaGecmisi);
            Controls.Add(lblMusteriSil);
            Name = "KiralamaGecmisi";
            Text = "KiralamaGecmisi";
            Load += KiralamaGecmisi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKiralamaGecmisi).EndInit();
            gbSiralama.ResumeLayout(false);
            gbSiralama.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMusteriSil;
        private DataGridView dgvKiralamaGecmisi;
        private GroupBox gbSiralama;
        private RadioButton rbTarihY_E;
        private RadioButton rbTarihE_Y;
        private Button btnGoster;
        private RadioButton rbToplamUcretArtan;
        private RadioButton rbToplamUcretAzalan;
        private RadioButton rbGunlukUcretArtan;
        private RadioButton rbGunlukUcretAzalan;
    }
}
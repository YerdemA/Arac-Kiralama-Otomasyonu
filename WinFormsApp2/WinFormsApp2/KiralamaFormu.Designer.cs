namespace WinFormsApp2
{
    partial class KiralamaFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralamaFormu));
            cmbMusteri = new ComboBox();
            cmbArac = new ComboBox();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            txtGunlukUcret = new TextBox();
            lblToplamUcret = new Label();
            btnKirala = new Button();
            panel1 = new Panel();
            lblStandartUcret = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblKiralayan = new Label();
            lblMusteriSil = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.Font = new Font("Segoe UI", 15F);
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(13, 100);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(350, 43);
            cmbMusteri.TabIndex = 0;
            // 
            // cmbArac
            // 
            cmbArac.Font = new Font("Segoe UI", 15F);
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(369, 100);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(356, 43);
            cmbArac.TabIndex = 1;
            cmbArac.SelectedIndexChanged += cmbArac_SelectedIndexChanged;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Font = new Font("Segoe UI", 15F);
            dtpBaslangic.Location = new Point(13, 213);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(350, 41);
            dtpBaslangic.TabIndex = 2;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Font = new Font("Segoe UI", 15F);
            dtpBitis.Location = new Point(369, 213);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(356, 41);
            dtpBitis.TabIndex = 3;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // txtGunlukUcret
            // 
            txtGunlukUcret.Font = new Font("Segoe UI", 15F);
            txtGunlukUcret.Location = new Point(112, 302);
            txtGunlukUcret.Name = "txtGunlukUcret";
            txtGunlukUcret.PlaceholderText = "Günlük Ücret";
            txtGunlukUcret.Size = new Size(200, 41);
            txtGunlukUcret.TabIndex = 4;
            txtGunlukUcret.TextChanged += txtGunlukUcret_TextChanged;
            // 
            // lblToplamUcret
            // 
            lblToplamUcret.AutoSize = true;
            lblToplamUcret.BackColor = Color.Transparent;
            lblToplamUcret.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblToplamUcret.ForeColor = Color.Snow;
            lblToplamUcret.Location = new Point(333, 297);
            lblToplamUcret.Name = "lblToplamUcret";
            lblToplamUcret.Size = new Size(247, 46);
            lblToplamUcret.TabIndex = 5;
            lblToplamUcret.Text = "Toplam Ücret?";
            // 
            // btnKirala
            // 
            btnKirala.BackColor = Color.Transparent;
            btnKirala.BackgroundImage = Properties.Resources.koyuAracEkle;
            btnKirala.BackgroundImageLayout = ImageLayout.Stretch;
            btnKirala.FlatStyle = FlatStyle.Flat;
            btnKirala.Font = new Font("Gill Sans Ultra Bold Condensed", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKirala.ForeColor = Color.Snow;
            btnKirala.Location = new Point(283, 391);
            btnKirala.Name = "btnKirala";
            btnKirala.Size = new Size(194, 88);
            btnKirala.TabIndex = 6;
            btnKirala.Text = "Kirala";
            btnKirala.UseVisualStyleBackColor = false;
            btnKirala.Click += btnKirala_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImage = Properties.Resources.KoyuAraba;
            panel1.Controls.Add(lblStandartUcret);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblKiralayan);
            panel1.Controls.Add(cmbMusteri);
            panel1.Controls.Add(cmbArac);
            panel1.Controls.Add(btnKirala);
            panel1.Controls.Add(dtpBaslangic);
            panel1.Controls.Add(lblToplamUcret);
            panel1.Controls.Add(dtpBitis);
            panel1.Controls.Add(txtGunlukUcret);
            panel1.Location = new Point(106, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 496);
            panel1.TabIndex = 8;
            // 
            // lblStandartUcret
            // 
            lblStandartUcret.AutoSize = true;
            lblStandartUcret.BackColor = Color.Transparent;
            lblStandartUcret.ForeColor = Color.Snow;
            lblStandartUcret.Location = new Point(112, 279);
            lblStandartUcret.Name = "lblStandartUcret";
            lblStandartUcret.Size = new Size(205, 20);
            lblStandartUcret.TabIndex = 11;
            lblStandartUcret.Text = "Aracın standart günlük ücreti?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(459, 167);
            label3.Name = "label3";
            label3.Size = new Size(255, 43);
            label3.TabIndex = 10;
            label3.Text = "HANGI TARIHE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(13, 167);
            label2.Name = "label2";
            label2.Size = new Size(299, 43);
            label2.TabIndex = 9;
            label2.Text = "HANGI TARIHTEN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(610, 54);
            label1.Name = "label1";
            label1.Size = new Size(104, 43);
            label1.TabIndex = 8;
            label1.Text = "ARAC";
            // 
            // lblKiralayan
            // 
            lblKiralayan.AutoSize = true;
            lblKiralayan.BackColor = Color.Transparent;
            lblKiralayan.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKiralayan.ForeColor = Color.Snow;
            lblKiralayan.Location = new Point(13, 54);
            lblKiralayan.Name = "lblKiralayan";
            lblKiralayan.Size = new Size(167, 43);
            lblKiralayan.TabIndex = 7;
            lblKiralayan.Text = "MUSTERI";
            // 
            // lblMusteriSil
            // 
            lblMusteriSil.AutoSize = true;
            lblMusteriSil.BackColor = Color.Transparent;
            lblMusteriSil.Font = new Font("Goudy Stout", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusteriSil.ForeColor = Color.Snow;
            lblMusteriSil.Location = new Point(188, 23);
            lblMusteriSil.Name = "lblMusteriSil";
            lblMusteriSil.Size = new Size(585, 58);
            lblMusteriSil.TabIndex = 9;
            lblMusteriSil.Text = "< KIRALAMA >";
            // 
            // KiralamaFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.anaSarkaplan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1015, 639);
            Controls.Add(lblMusteriSil);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KiralamaFormu";
            Text = "Araç Kiralama Otomasyonu";
            Load += KiralamaFormu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMusteri;
        private ComboBox cmbArac;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private TextBox txtGunlukUcret;
        private Label lblToplamUcret;
        private Button btnKirala;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblKiralayan;
        private Label lblMusteriSil;
        private Label lblStandartUcret;
    }
}
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnKayitOl = new Button();
            lblKayitOl = new Label();
            btnLogin = new Button();
            chkBeniHatirla = new CheckBox();
            btnSifremiUnuttum = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtSifre = new MaskedTextBox();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pbAraba = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnKayitOl);
            panel1.Controls.Add(lblKayitOl);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(chkBeniHatirla);
            panel1.Controls.Add(btnSifremiUnuttum);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pbAraba);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 320);
            panel1.TabIndex = 0;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Snow;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Tw Cen MT Condensed Extra Bold", 10F, FontStyle.Bold);
            btnKayitOl.Location = new Point(275, 235);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(100, 55);
            btnKayitOl.TabIndex = 12;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // lblKayitOl
            // 
            lblKayitOl.AutoSize = true;
            lblKayitOl.BackColor = Color.Transparent;
            lblKayitOl.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKayitOl.ForeColor = Color.Snow;
            lblKayitOl.Location = new Point(150, 9);
            lblKayitOl.Name = "lblKayitOl";
            lblKayitOl.Size = new Size(185, 43);
            lblKayitOl.TabIndex = 11;
            lblKayitOl.Text = "GiriS Yap";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Snow;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tw Cen MT Condensed Extra Bold", 15F, FontStyle.Bold);
            btnLogin.Location = new Point(381, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 75);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkBeniHatirla
            // 
            chkBeniHatirla.AutoSize = true;
            chkBeniHatirla.BackColor = Color.MidnightBlue;
            chkBeniHatirla.FlatStyle = FlatStyle.Flat;
            chkBeniHatirla.Font = new Font("Rockwell", 9F);
            chkBeniHatirla.ForeColor = Color.Snow;
            chkBeniHatirla.Location = new Point(231, 181);
            chkBeniHatirla.Name = "chkBeniHatirla";
            chkBeniHatirla.Size = new Size(108, 21);
            chkBeniHatirla.TabIndex = 9;
            chkBeniHatirla.Text = "Beni hatırla";
            chkBeniHatirla.UseVisualStyleBackColor = false;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.AutoSize = true;
            btnSifremiUnuttum.BackColor = Color.MidnightBlue;
            btnSifremiUnuttum.BorderStyle = BorderStyle.FixedSingle;
            btnSifremiUnuttum.LinkColor = Color.Snow;
            btnSifremiUnuttum.Location = new Point(356, 180);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(117, 22);
            btnSifremiUnuttum.TabIndex = 7;
            btnSifremiUnuttum.TabStop = true;
            btnSifremiUnuttum.Text = "Şifremi unuttum";
            btnSifremiUnuttum.LinkClicked += btnSifremiUnuttum_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = Properties.Resources.locked;
            pictureBox2.Location = new Point(472, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(472, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 15F);
            txtSifre.Location = new Point(223, 132);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(288, 41);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 15F);
            txtKullaniciAdi.Location = new Point(223, 82);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(288, 41);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 17F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(0, 81);
            label3.Name = "label3";
            label3.Size = new Size(214, 40);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 17F);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(112, 133);
            label2.Name = "label2";
            label2.Size = new Size(102, 40);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // pbAraba
            // 
            pbAraba.BackColor = Color.Transparent;
            pbAraba.Image = Properties.Resources.loginPageArabasi;
            pbAraba.Location = new Point(3, 155);
            pbAraba.Name = "pbAraba";
            pbAraba.Size = new Size(245, 142);
            pbAraba.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAraba.TabIndex = 13;
            pbAraba.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(535, 338);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kiralama Otomasyonu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox chkBeniHatirla;
        private LinkLabel btnSifremiUnuttum;
        private Button btnLogin;
        private Label lblKayitOl;
        private Button btnKayitOl;
        private PictureBox pbAraba;
    }
}

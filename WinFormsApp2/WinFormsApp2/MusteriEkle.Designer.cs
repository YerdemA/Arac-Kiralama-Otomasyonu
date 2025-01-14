namespace WinFormsApp2
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            lblMusteriEkle = new Label();
            panel1 = new Panel();
            dtpDogumTarihi = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefonNo = new TextBox();
            txtKimlikNo = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblAd = new Label();
            btnEkle = new Button();
            btnTemizle = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMusteriEkle
            // 
            lblMusteriEkle.AutoSize = true;
            lblMusteriEkle.BackColor = Color.Transparent;
            lblMusteriEkle.Font = new Font("Goudy Stout", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusteriEkle.ForeColor = Color.Snow;
            lblMusteriEkle.Location = new Point(64, 9);
            lblMusteriEkle.Name = "lblMusteriEkle";
            lblMusteriEkle.Size = new Size(740, 58);
            lblMusteriEkle.TabIndex = 0;
            lblMusteriEkle.Text = "< Musteri Ekle >";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(dtpDogumTarihi);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtTelefonNo);
            panel1.Controls.Add(txtKimlikNo);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblAd);
            panel1.Location = new Point(24, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 435);
            panel1.TabIndex = 1;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 15F);
            dtpDogumTarihi.Location = new Point(300, 347);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(304, 41);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(300, 278);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 41);
            txtEmail.TabIndex = 10;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Font = new Font("Segoe UI", 15F);
            txtTelefonNo.Location = new Point(300, 215);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(304, 41);
            txtTelefonNo.TabIndex = 9;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Font = new Font("Segoe UI", 15F);
            txtKimlikNo.Location = new Point(300, 154);
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(304, 41);
            txtKimlikNo.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 15F);
            txtSoyad.Location = new Point(300, 88);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(304, 41);
            txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 15F);
            txtAd.Location = new Point(300, 25);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(304, 41);
            txtAd.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 351);
            label6.Name = "label6";
            label6.Size = new Size(275, 37);
            label6.TabIndex = 5;
            label6.Text = "DOGUM TARiHi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(148, 90);
            label5.Name = "label5";
            label5.Size = new Size(146, 37);
            label5.TabIndex = 4;
            label5.Text = "SOYAD :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 156);
            label4.Name = "label4";
            label4.Size = new Size(254, 37);
            label4.TabIndex = 3;
            label4.Text = "TC KiMLiK NO :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 217);
            label3.Name = "label3";
            label3.Size = new Size(199, 37);
            label3.TabIndex = 2;
            label3.Text = "Telefon No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 280);
            label2.Name = "label2";
            label2.Size = new Size(165, 37);
            label2.TabIndex = 1;
            label2.Text = "E - Mail :";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Forte", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAd.Location = new Point(210, 29);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(84, 37);
            lblAd.TabIndex = 0;
            lblAd.Text = "AD :";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Snow;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Cooper Black", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEkle.Location = new Point(734, 180);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(166, 120);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Black;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTemizle.ForeColor = Color.Snow;
            btnTemizle.Location = new Point(730, 322);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(175, 120);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "TEMIZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(747, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MusteriBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(921, 538);
            Controls.Add(btnTemizle);
            Controls.Add(btnEkle);
            Controls.Add(panel1);
            Controls.Add(lblMusteriEkle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekle";
            Load += MusteriEkle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMusteriEkle;
        private Panel panel1;
        private TextBox txtAd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblAd;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtEmail;
        private TextBox txtTelefonNo;
        private TextBox txtKimlikNo;
        private TextBox txtSoyad;
        private Button btnEkle;
        private Button btnTemizle;
        private PictureBox pictureBox1;
    }
}
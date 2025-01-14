namespace WinFormsApp2
{
    partial class SifremiUnuttumFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttumFormu));
            lblEmail = new Label();
            txtEmail = new TextBox();
            dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            txtTcKimlik = new TextBox();
            label1 = new Label();
            txtYeniSifre = new TextBox();
            label2 = new Label();
            btnSifreDegistir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dateTimeChartRangeControlClient1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Gainsboro;
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Gill Sans Ultra Bold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(12, 39);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(252, 55);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-Mail Adresi";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.Font = new Font("Segoe UI", 20F);
            txtEmail.Location = new Point(12, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(402, 52);
            txtEmail.TabIndex = 1;
            // 
            // txtTcKimlik
            // 
            txtTcKimlik.BackColor = Color.Gainsboro;
            txtTcKimlik.Font = new Font("Segoe UI", 20F);
            txtTcKimlik.Location = new Point(12, 227);
            txtTcKimlik.Name = "txtTcKimlik";
            txtTcKimlik.Size = new Size(402, 52);
            txtTcKimlik.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Gill Sans Ultra Bold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 178);
            label1.Name = "label1";
            label1.Size = new Size(377, 55);
            label1.TabIndex = 2;
            label1.Text = "TC. Kimlik Numarası";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.BackColor = Color.LightGray;
            txtYeniSifre.Font = new Font("Segoe UI", 20F);
            txtYeniSifre.Location = new Point(12, 365);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(402, 52);
            txtYeniSifre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Gill Sans Ultra Bold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 316);
            label2.Name = "label2";
            label2.Size = new Size(198, 55);
            label2.TabIndex = 4;
            label2.Text = "Yeni Şifre";
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = Color.Snow;
            btnSifreDegistir.FlatStyle = FlatStyle.Flat;
            btnSifreDegistir.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSifreDegistir.Location = new Point(455, 233);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(167, 107);
            btnSifreDegistir.TabIndex = 6;
            btnSifreDegistir.Text = "Sifre Degistir";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dusunenAdam;
            pictureBox1.Location = new Point(515, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // SifremiUnuttumFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 34, 68);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(650, 450);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtTcKimlik);
            Controls.Add(txtEmail);
            Controls.Add(btnSifreDegistir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEmail);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SifremiUnuttumFormu";
            Text = "Şifremi Unuttum";
            ((System.ComponentModel.ISupportInitialize)dateTimeChartRangeControlClient1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private TextBox txtTcKimlik;
        private Label label1;
        private TextBox txtYeniSifre;
        private Label label2;
        private Button btnSifreDegistir;
        private PictureBox pictureBox1;
    }
}
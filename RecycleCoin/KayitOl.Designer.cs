
namespace RecycleCoin
{
    partial class KayitOl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Kulad = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_Onay = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Kulad = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_SifreOnay = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Yas = new System.Windows.Forms.Label();
            this.txt_Yas = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_sifreGizle = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_sifreGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(344, 45);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(31, 20);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "Ad:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(322, 84);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(53, 20);
            this.lbl_Soyad.TabIndex = 0;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // lbl_Kulad
            // 
            this.lbl_Kulad.AutoSize = true;
            this.lbl_Kulad.Location = new System.Drawing.Point(280, 162);
            this.lbl_Kulad.Name = "lbl_Kulad";
            this.lbl_Kulad.Size = new System.Drawing.Size(95, 20);
            this.lbl_Kulad.TabIndex = 0;
            this.lbl_Kulad.Text = "Kullanıcı Adı:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(333, 201);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(42, 20);
            this.lbl_Sifre.TabIndex = 0;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_Onay
            // 
            this.lbl_Onay.AutoSize = true;
            this.lbl_Onay.Location = new System.Drawing.Point(297, 240);
            this.lbl_Onay.Name = "lbl_Onay";
            this.lbl_Onay.Size = new System.Drawing.Size(80, 20);
            this.lbl_Onay.TabIndex = 0;
            this.lbl_Onay.Text = "Şifre Onay:";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(334, 279);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(41, 20);
            this.lbl_Mail.TabIndex = 0;
            this.lbl_Mail.Text = "Mail:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(383, 42);
            this.txt_Ad.Multiline = true;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.PlaceholderText = "Ad";
            this.txt_Ad.Size = new System.Drawing.Size(186, 29);
            this.txt_Ad.TabIndex = 1;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(383, 81);
            this.txt_Soyad.Multiline = true;
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.PlaceholderText = "Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(186, 29);
            this.txt_Soyad.TabIndex = 2;
            // 
            // txt_Kulad
            // 
            this.txt_Kulad.Location = new System.Drawing.Point(383, 159);
            this.txt_Kulad.Multiline = true;
            this.txt_Kulad.Name = "txt_Kulad";
            this.txt_Kulad.PlaceholderText = "Kullanıcı Adı";
            this.txt_Kulad.Size = new System.Drawing.Size(186, 29);
            this.txt_Kulad.TabIndex = 4;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(383, 198);
            this.txt_Sifre.Multiline = true;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.PlaceholderText = "Şifre";
            this.txt_Sifre.Size = new System.Drawing.Size(186, 29);
            this.txt_Sifre.TabIndex = 5;
            // 
            // txt_SifreOnay
            // 
            this.txt_SifreOnay.Location = new System.Drawing.Point(383, 237);
            this.txt_SifreOnay.Multiline = true;
            this.txt_SifreOnay.Name = "txt_SifreOnay";
            this.txt_SifreOnay.PasswordChar = '*';
            this.txt_SifreOnay.PlaceholderText = "Şifre Onaylama";
            this.txt_SifreOnay.Size = new System.Drawing.Size(186, 29);
            this.txt_SifreOnay.TabIndex = 6;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(383, 276);
            this.txt_Mail.Multiline = true;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.PlaceholderText = "Mail";
            this.txt_Mail.Size = new System.Drawing.Size(186, 29);
            this.txt_Mail.TabIndex = 7;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(417, 357);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(112, 41);
            this.btn_Kaydet.TabIndex = 9;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(383, 315);
            this.txt_Telefon.MaxLength = 11;
            this.txt_Telefon.Multiline = true;
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.PlaceholderText = "Telefon Numarası";
            this.txt_Telefon.Size = new System.Drawing.Size(186, 29);
            this.txt_Telefon.TabIndex = 8;
            this.txt_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefon_KeyPress);
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(247, 318);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(128, 20);
            this.lbl_Telefon.TabIndex = 0;
            this.lbl_Telefon.Text = "Telefon Numarası:";
            // 
            // lbl_Yas
            // 
            this.lbl_Yas.AutoSize = true;
            this.lbl_Yas.Location = new System.Drawing.Point(342, 123);
            this.lbl_Yas.Name = "lbl_Yas";
            this.lbl_Yas.Size = new System.Drawing.Size(33, 20);
            this.lbl_Yas.TabIndex = 0;
            this.lbl_Yas.Text = "Yaş:";
            // 
            // txt_Yas
            // 
            this.txt_Yas.Location = new System.Drawing.Point(383, 120);
            this.txt_Yas.MaxLength = 3;
            this.txt_Yas.Multiline = true;
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.PlaceholderText = "Yaş";
            this.txt_Yas.Size = new System.Drawing.Size(186, 29);
            this.txt_Yas.TabIndex = 3;
          
            this.txt_Yas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Yas_KeyPress);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 488);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "<- Giriş yap";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_sifreGizle
            // 
            this.btn_sifreGizle.BackColor = System.Drawing.Color.Transparent;
            this.btn_sifreGizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sifreGizle.BackgroundImage")));
            this.btn_sifreGizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sifreGizle.Location = new System.Drawing.Point(529, 198);
            this.btn_sifreGizle.Name = "btn_sifreGizle";
            this.btn_sifreGizle.Size = new System.Drawing.Size(40, 29);
            this.btn_sifreGizle.TabIndex = 11;
            this.btn_sifreGizle.UseVisualStyleBackColor = false;
            this.btn_sifreGizle.Click += new System.EventHandler(this.btn_sifreGizle_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btn_sifreGoster
            // 
            this.btn_sifreGoster.BackColor = System.Drawing.Color.Transparent;
            this.btn_sifreGoster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sifreGoster.BackgroundImage")));
            this.btn_sifreGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sifreGoster.Location = new System.Drawing.Point(529, 198);
            this.btn_sifreGoster.Name = "btn_sifreGoster";
            this.btn_sifreGoster.Size = new System.Drawing.Size(40, 29);
            this.btn_sifreGoster.TabIndex = 10;
            this.btn_sifreGoster.UseVisualStyleBackColor = false;
            this.btn_sifreGoster.Click += new System.EventHandler(this.btn_sifreGoster_Click);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(956, 529);
            this.Controls.Add(this.btn_sifreGoster);
            this.Controls.Add(this.btn_sifreGizle);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_SifreOnay);
            this.Controls.Add(this.txt_Yas);
            this.Controls.Add(this.txt_Kulad);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.lbl_Onay);
            this.Controls.Add(this.lbl_Yas);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Kulad);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.txt_Sifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitOl";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KayitOl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KayitOl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Kulad;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_Onay;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Kulad;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_SifreOnay;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Yas;
        private System.Windows.Forms.TextBox txt_Yas;
        private System.Windows.Forms.Button btn_back;
        protected System.Windows.Forms.Button btn_sifreGizle;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btn_sifreGoster;
    }
}
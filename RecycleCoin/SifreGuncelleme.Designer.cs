
namespace RecycleCoin
{
    partial class SifreGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreGuncelleme));
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.txt_SifreOnay = new System.Windows.Forms.TextBox();
            this.txt_YeniSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_KulAd = new System.Windows.Forms.TextBox();
            this.lbl_KulAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(183, 163);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(118, 38);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kapat.BackgroundImage")));
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.Location = new System.Drawing.Point(283, 74);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(40, 29);
            this.btn_kapat.TabIndex = 19;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.BackColor = System.Drawing.Color.Transparent;
            this.btn_ac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ac.BackgroundImage")));
            this.btn_ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ac.Location = new System.Drawing.Point(283, 74);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(40, 29);
            this.btn_ac.TabIndex = 18;
            this.btn_ac.UseVisualStyleBackColor = false;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // txt_SifreOnay
            // 
            this.txt_SifreOnay.Location = new System.Drawing.Point(165, 118);
            this.txt_SifreOnay.Multiline = true;
            this.txt_SifreOnay.Name = "txt_SifreOnay";
            this.txt_SifreOnay.PlaceholderText = "Şifre Onaylama";
            this.txt_SifreOnay.Size = new System.Drawing.Size(158, 29);
            this.txt_SifreOnay.TabIndex = 3;
            // 
            // txt_YeniSifre
            // 
            this.txt_YeniSifre.Location = new System.Drawing.Point(165, 74);
            this.txt_YeniSifre.Multiline = true;
            this.txt_YeniSifre.Name = "txt_YeniSifre";
            this.txt_YeniSifre.PasswordChar = '*';
            this.txt_YeniSifre.PlaceholderText = "Yeni Şifre";
            this.txt_YeniSifre.Size = new System.Drawing.Size(158, 29);
            this.txt_YeniSifre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre Onay:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(75, 77);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(73, 20);
            this.lbl_Sifre.TabIndex = 6;
            this.lbl_Sifre.Text = "Yeni Şifre:";
            // 
            // txt_KulAd
            // 
            this.txt_KulAd.Location = new System.Drawing.Point(165, 27);
            this.txt_KulAd.Multiline = true;
            this.txt_KulAd.Name = "txt_KulAd";
            this.txt_KulAd.PlaceholderText = "Kullanıcı Adı";
            this.txt_KulAd.Size = new System.Drawing.Size(158, 29);
            this.txt_KulAd.TabIndex = 1;
            // 
            // lbl_KulAd
            // 
            this.lbl_KulAd.AutoSize = true;
            this.lbl_KulAd.Location = new System.Drawing.Point(62, 30);
            this.lbl_KulAd.Name = "lbl_KulAd";
            this.lbl_KulAd.Size = new System.Drawing.Size(95, 20);
            this.lbl_KulAd.TabIndex = 5;
            this.lbl_KulAd.Text = "Kullanıcı Adı:";
            // 
            // SifreGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(424, 219);
            this.Controls.Add(this.txt_KulAd);
            this.Controls.Add(this.lbl_KulAd);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.txt_SifreOnay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.txt_YeniSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreGuncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.TextBox txt_SifreOnay;
        private System.Windows.Forms.TextBox txt_YeniSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_KulAd;
        private System.Windows.Forms.Label lbl_KulAd;
    }
}
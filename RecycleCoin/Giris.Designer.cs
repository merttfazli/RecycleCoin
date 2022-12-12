
namespace RecycleCoin
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.lbl_Kulad = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_Kulad = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.link_Sifremiunuttum = new System.Windows.Forms.LinkLabel();
            this.link_KayitOl = new System.Windows.Forms.LinkLabel();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_appStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Kulad
            // 
            this.lbl_Kulad.AutoSize = true;
            this.lbl_Kulad.Location = new System.Drawing.Point(89, 44);
            this.lbl_Kulad.Name = "lbl_Kulad";
            this.lbl_Kulad.Size = new System.Drawing.Size(95, 20);
            this.lbl_Kulad.TabIndex = 0;
            this.lbl_Kulad.Text = "Kullanıcı Adı:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(142, 83);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(42, 20);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // txt_Kulad
            // 
            this.txt_Kulad.Location = new System.Drawing.Point(190, 41);
            this.txt_Kulad.Multiline = true;
            this.txt_Kulad.Name = "txt_Kulad";
            this.txt_Kulad.PlaceholderText = "Kullanıcı Adı";
            this.txt_Kulad.Size = new System.Drawing.Size(160, 29);
            this.txt_Kulad.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(190, 80);
            this.txt_Sifre.Multiline = true;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.PlaceholderText = "Şifre";
            this.txt_Sifre.Size = new System.Drawing.Size(160, 29);
            this.txt_Sifre.TabIndex = 3;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(210, 158);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(113, 46);
            this.btn_Giris.TabIndex = 4;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // link_Sifremiunuttum
            // 
            this.link_Sifremiunuttum.AutoSize = true;
            this.link_Sifremiunuttum.LinkColor = System.Drawing.Color.Black;
            this.link_Sifremiunuttum.Location = new System.Drawing.Point(124, 121);
            this.link_Sifremiunuttum.Name = "link_Sifremiunuttum";
            this.link_Sifremiunuttum.Size = new System.Drawing.Size(117, 20);
            this.link_Sifremiunuttum.TabIndex = 6;
            this.link_Sifremiunuttum.TabStop = true;
            this.link_Sifremiunuttum.Text = "Şifremi Unuttum";
            this.link_Sifremiunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Sifremiunuttum_LinkClicked);
            // 
            // link_KayitOl
            // 
            this.link_KayitOl.AutoSize = true;
            this.link_KayitOl.LinkColor = System.Drawing.Color.Black;
            this.link_KayitOl.Location = new System.Drawing.Point(310, 121);
            this.link_KayitOl.Name = "link_KayitOl";
            this.link_KayitOl.Size = new System.Drawing.Size(61, 20);
            this.link_KayitOl.TabIndex = 7;
            this.link_KayitOl.TabStop = true;
            this.link_KayitOl.Text = "Kayıt Ol";
            this.link_KayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_KayitOl_LinkClicked);
            // 
            // btn_ac
            // 
            this.btn_ac.BackColor = System.Drawing.Color.Transparent;
            this.btn_ac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ac.BackgroundImage")));
            this.btn_ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ac.Location = new System.Drawing.Point(310, 80);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(40, 29);
            this.btn_ac.TabIndex = 20;
            this.btn_ac.UseVisualStyleBackColor = false;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kapat.BackgroundImage")));
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.Location = new System.Drawing.Point(310, 80);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(40, 29);
            this.btn_kapat.TabIndex = 21;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_appStop
            // 
            this.btn_appStop.Location = new System.Drawing.Point(423, 3);
            this.btn_appStop.Name = "btn_appStop";
            this.btn_appStop.Size = new System.Drawing.Size(40, 29);
            this.btn_appStop.TabIndex = 22;
            this.btn_appStop.Text = "X";
            this.btn_appStop.UseVisualStyleBackColor = true;
            this.btn_appStop.Click += new System.EventHandler(this.btn_appStop_Click);
            // 
            // Giris
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(466, 239);
            this.Controls.Add(this.btn_appStop);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.link_KayitOl);
            this.Controls.Add(this.link_Sifremiunuttum);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Kulad);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Kulad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kulad;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_Kulad;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.LinkLabel link_Sifremiunuttum;
        private System.Windows.Forms.LinkLabel link_KayitOl;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_appStop;
    }
}


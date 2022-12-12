
namespace RecycleCoin
{
    partial class SifremiUnuttum
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
            this.btn_Gönder = new System.Windows.Forms.Button();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Kod = new System.Windows.Forms.TextBox();
            this.lbl_Kod = new System.Windows.Forms.Label();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.link_YenidenKod = new System.Windows.Forms.LinkLabel();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gönder
            // 
            this.btn_Gönder.Location = new System.Drawing.Point(189, 73);
            this.btn_Gönder.Name = "btn_Gönder";
            this.btn_Gönder.Size = new System.Drawing.Size(107, 31);
            this.btn_Gönder.TabIndex = 2;
            this.btn_Gönder.Text = "Gönder";
            this.btn_Gönder.UseVisualStyleBackColor = true;
            this.btn_Gönder.Click += new System.EventHandler(this.btn_Gönder_Click);
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(102, 33);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(41, 20);
            this.lbl_Mail.TabIndex = 5;
            this.lbl_Mail.Text = "Mail:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(151, 30);
            this.txt_Mail.Multiline = true;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.PlaceholderText = "Mail";
            this.txt_Mail.Size = new System.Drawing.Size(184, 29);
            this.txt_Mail.TabIndex = 1;
            // 
            // txt_Kod
            // 
            this.txt_Kod.Location = new System.Drawing.Point(152, 122);
            this.txt_Kod.Multiline = true;
            this.txt_Kod.Name = "txt_Kod";
            this.txt_Kod.PlaceholderText = "Onay Kodu";
            this.txt_Kod.Size = new System.Drawing.Size(184, 29);
            this.txt_Kod.TabIndex = 3;
            // 
            // lbl_Kod
            // 
            this.lbl_Kod.AutoSize = true;
            this.lbl_Kod.Location = new System.Drawing.Point(67, 125);
            this.lbl_Kod.Name = "lbl_Kod";
            this.lbl_Kod.Size = new System.Drawing.Size(77, 20);
            this.lbl_Kod.TabIndex = 6;
            this.lbl_Kod.Text = "Onay Kod:";
            // 
            // btn_Onay
            // 
            this.btn_Onay.Location = new System.Drawing.Point(361, 122);
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.Size = new System.Drawing.Size(105, 29);
            this.btn_Onay.TabIndex = 4;
            this.btn_Onay.Text = "Onayla";
            this.btn_Onay.UseVisualStyleBackColor = true;
            this.btn_Onay.Click += new System.EventHandler(this.btn_Onay_Click);
            // 
            // link_YenidenKod
            // 
            this.link_YenidenKod.AutoSize = true;
            this.link_YenidenKod.Location = new System.Drawing.Point(135, 164);
            this.link_YenidenKod.Name = "link_YenidenKod";
            this.link_YenidenKod.Size = new System.Drawing.Size(219, 20);
            this.link_YenidenKod.TabIndex = 7;
            this.link_YenidenKod.TabStop = true;
            this.link_YenidenKod.Text = "Yeniden Kod Almak İçin Tıklayın";
            this.link_YenidenKod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_YenidenKod_LinkClicked);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 164);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "<- Giriş yap";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(514, 198);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.link_YenidenKod);
            this.Controls.Add(this.txt_Kod);
            this.Controls.Add(this.lbl_Kod);
            this.Controls.Add(this.btn_Onay);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.btn_Gönder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gönder;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_Kod;
        private System.Windows.Forms.Label lbl_Kod;
        private System.Windows.Forms.Button btn_Onay;
        private System.Windows.Forms.LinkLabel link_YenidenKod;
        private System.Windows.Forms.Button btn_back;
    }
}
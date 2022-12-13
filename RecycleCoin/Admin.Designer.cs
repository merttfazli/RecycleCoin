
namespace RecycleCoin
{
    partial class Admin
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
            this.tab_CoinInfo = new System.Windows.Forms.TabControl();
            this.tab_List = new System.Windows.Forms.TabPage();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_KulSil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.cmb_KullaniciTur = new System.Windows.Forms.ComboBox();
            this.cmb_KullaniciTurListele = new System.Windows.Forms.ComboBox();
            this.txt_Arama = new System.Windows.Forms.TextBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Kulad = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciTur = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Kulad = new System.Windows.Forms.Label();
            this.txt_Yas = new System.Windows.Forms.TextBox();
            this.lbl_Yas = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.dataGrid_Kullanicilar = new System.Windows.Forms.DataGridView();
            this.tab_Onay = new System.Windows.Forms.TabPage();
            this.cmb_Onay = new System.Windows.Forms.ComboBox();
            this.lbl_Onay = new System.Windows.Forms.Label();
            this.dataGrid_Onay = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_RecycleFiyat = new System.Windows.Forms.TextBox();
            this.txt_ToplamRecycle = new System.Windows.Forms.TextBox();
            this.lbl_RecycleFiyat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Reycle = new System.Windows.Forms.Label();
            this.dataGrid_Para = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab_CoinInfo.SuspendLayout();
            this.tab_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kullanicilar)).BeginInit();
            this.tab_Onay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Onay)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Para)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_CoinInfo
            // 
            this.tab_CoinInfo.Controls.Add(this.tab_List);
            this.tab_CoinInfo.Controls.Add(this.tab_Onay);
            this.tab_CoinInfo.Controls.Add(this.tabPage1);
            this.tab_CoinInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_CoinInfo.Location = new System.Drawing.Point(0, 0);
            this.tab_CoinInfo.Name = "tab_CoinInfo";
            this.tab_CoinInfo.SelectedIndex = 0;
            this.tab_CoinInfo.Size = new System.Drawing.Size(1177, 756);
            this.tab_CoinInfo.TabIndex = 0;
            // 
            // tab_List
            // 
            this.tab_List.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tab_List.Controls.Add(this.btn_Exit);
            this.tab_List.Controls.Add(this.btn_KulSil);
            this.tab_List.Controls.Add(this.btn_Guncelle);
            this.tab_List.Controls.Add(this.cmb_KullaniciTur);
            this.tab_List.Controls.Add(this.cmb_KullaniciTurListele);
            this.tab_List.Controls.Add(this.txt_Arama);
            this.tab_List.Controls.Add(this.txt_Telefon);
            this.tab_List.Controls.Add(this.txt_Mail);
            this.tab_List.Controls.Add(this.txt_Kulad);
            this.tab_List.Controls.Add(this.lbl_KullaniciTur);
            this.tab_List.Controls.Add(this.lbl_Telefon);
            this.tab_List.Controls.Add(this.lbl_Mail);
            this.tab_List.Controls.Add(this.lbl_Kulad);
            this.tab_List.Controls.Add(this.txt_Yas);
            this.tab_List.Controls.Add(this.lbl_Yas);
            this.tab_List.Controls.Add(this.txt_Soyad);
            this.tab_List.Controls.Add(this.lbl_Soyad);
            this.tab_List.Controls.Add(this.txt_Ad);
            this.tab_List.Controls.Add(this.lbl_Ad);
            this.tab_List.Controls.Add(this.dataGrid_Kullanicilar);
            this.tab_List.Location = new System.Drawing.Point(4, 29);
            this.tab_List.Name = "tab_List";
            this.tab_List.Padding = new System.Windows.Forms.Padding(3);
            this.tab_List.Size = new System.Drawing.Size(1169, 723);
            this.tab_List.TabIndex = 0;
            this.tab_List.Text = "Listeleme";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1072, 6);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 29);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_KulSil
            // 
            this.btn_KulSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KulSil.Location = new System.Drawing.Point(724, 151);
            this.btn_KulSil.Name = "btn_KulSil";
            this.btn_KulSil.Size = new System.Drawing.Size(195, 35);
            this.btn_KulSil.TabIndex = 13;
            this.btn_KulSil.Text = "Kullanıcı Sil";
            this.btn_KulSil.UseVisualStyleBackColor = true;
            this.btn_KulSil.Click += new System.EventHandler(this.btn_KulSil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Guncelle.Location = new System.Drawing.Point(724, 110);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(195, 35);
            this.btn_Guncelle.TabIndex = 12;
            this.btn_Guncelle.Text = "Kullanıcı Türü Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // cmb_KullaniciTur
            // 
            this.cmb_KullaniciTur.FormattingEnabled = true;
            this.cmb_KullaniciTur.Items.AddRange(new object[] {
            "Admin",
            "Sorumlu",
            "Kullanıcı"});
            this.cmb_KullaniciTur.Location = new System.Drawing.Point(724, 29);
            this.cmb_KullaniciTur.Name = "cmb_KullaniciTur";
            this.cmb_KullaniciTur.Size = new System.Drawing.Size(195, 28);
            this.cmb_KullaniciTur.TabIndex = 11;
            // 
            // cmb_KullaniciTurListele
            // 
            this.cmb_KullaniciTurListele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_KullaniciTurListele.FormattingEnabled = true;
            this.cmb_KullaniciTurListele.Items.AddRange(new object[] {
            "Admin",
            "Sorumlu",
            "Kullanıcı"});
            this.cmb_KullaniciTurListele.Location = new System.Drawing.Point(440, 197);
            this.cmb_KullaniciTurListele.Name = "cmb_KullaniciTurListele";
            this.cmb_KullaniciTurListele.Size = new System.Drawing.Size(288, 36);
            this.cmb_KullaniciTurListele.TabIndex = 10;
            this.cmb_KullaniciTurListele.Text = "Kullanıcı Türüne Göre Listele ";
            this.cmb_KullaniciTurListele.SelectedIndexChanged += new System.EventHandler(this.cmb_KullaniciTurListele_SelectedIndexChanged);
            // 
            // txt_Arama
            // 
            this.txt_Arama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Arama.Location = new System.Drawing.Point(6, 197);
            this.txt_Arama.Multiline = true;
            this.txt_Arama.Name = "txt_Arama";
            this.txt_Arama.PlaceholderText = "Ad\'a Göre Arama                                    🔍";
            this.txt_Arama.Size = new System.Drawing.Size(416, 36);
            this.txt_Arama.TabIndex = 9;
            this.txt_Arama.TextChanged += new System.EventHandler(this.txt_Arama_TextChanged);
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(401, 110);
            this.txt_Telefon.Multiline = true;
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.ReadOnly = true;
            this.txt_Telefon.Size = new System.Drawing.Size(195, 29);
            this.txt_Telefon.TabIndex = 6;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(401, 69);
            this.txt_Mail.Multiline = true;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.ReadOnly = true;
            this.txt_Mail.Size = new System.Drawing.Size(195, 29);
            this.txt_Mail.TabIndex = 7;
            // 
            // txt_Kulad
            // 
            this.txt_Kulad.Location = new System.Drawing.Point(401, 28);
            this.txt_Kulad.Multiline = true;
            this.txt_Kulad.Name = "txt_Kulad";
            this.txt_Kulad.ReadOnly = true;
            this.txt_Kulad.Size = new System.Drawing.Size(195, 29);
            this.txt_Kulad.TabIndex = 8;
            // 
            // lbl_KullaniciTur
            // 
            this.lbl_KullaniciTur.AutoSize = true;
            this.lbl_KullaniciTur.Location = new System.Drawing.Point(617, 32);
            this.lbl_KullaniciTur.Name = "lbl_KullaniciTur";
            this.lbl_KullaniciTur.Size = new System.Drawing.Size(101, 20);
            this.lbl_KullaniciTur.TabIndex = 3;
            this.lbl_KullaniciTur.Text = "Kullanıcı Türü:";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(267, 116);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(128, 20);
            this.lbl_Telefon.TabIndex = 3;
            this.lbl_Telefon.Text = "Telefon Numarası:";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(354, 72);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(41, 20);
            this.lbl_Mail.TabIndex = 4;
            this.lbl_Mail.Text = "Mail:";
            // 
            // lbl_Kulad
            // 
            this.lbl_Kulad.AutoSize = true;
            this.lbl_Kulad.Location = new System.Drawing.Point(300, 31);
            this.lbl_Kulad.Name = "lbl_Kulad";
            this.lbl_Kulad.Size = new System.Drawing.Size(95, 20);
            this.lbl_Kulad.TabIndex = 5;
            this.lbl_Kulad.Text = "Kullanıcı Adı:";
            // 
            // txt_Yas
            // 
            this.txt_Yas.Location = new System.Drawing.Point(72, 110);
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.ReadOnly = true;
            this.txt_Yas.Size = new System.Drawing.Size(167, 27);
            this.txt_Yas.TabIndex = 2;
            // 
            // lbl_Yas
            // 
            this.lbl_Yas.AutoSize = true;
            this.lbl_Yas.Location = new System.Drawing.Point(33, 115);
            this.lbl_Yas.Name = "lbl_Yas";
            this.lbl_Yas.Size = new System.Drawing.Size(33, 20);
            this.lbl_Yas.TabIndex = 1;
            this.lbl_Yas.Text = "Yaş:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(72, 71);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(167, 27);
            this.txt_Soyad.TabIndex = 2;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(13, 74);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(53, 20);
            this.lbl_Soyad.TabIndex = 1;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(72, 32);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(167, 27);
            this.txt_Ad.TabIndex = 2;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(35, 33);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(31, 20);
            this.lbl_Ad.TabIndex = 1;
            this.lbl_Ad.Text = "Ad:";
            // 
            // dataGrid_Kullanicilar
            // 
            this.dataGrid_Kullanicilar.AllowUserToAddRows = false;
            this.dataGrid_Kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Kullanicilar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_Kullanicilar.Location = new System.Drawing.Point(3, 257);
            this.dataGrid_Kullanicilar.Name = "dataGrid_Kullanicilar";
            this.dataGrid_Kullanicilar.ReadOnly = true;
            this.dataGrid_Kullanicilar.RowHeadersWidth = 51;
            this.dataGrid_Kullanicilar.RowTemplate.Height = 29;
            this.dataGrid_Kullanicilar.Size = new System.Drawing.Size(1163, 463);
            this.dataGrid_Kullanicilar.TabIndex = 0;
            this.dataGrid_Kullanicilar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_Kullanicilar_CellMouseDoubleClick);
            // 
            // tab_Onay
            // 
            this.tab_Onay.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tab_Onay.Controls.Add(this.cmb_Onay);
            this.tab_Onay.Controls.Add(this.lbl_Onay);
            this.tab_Onay.Controls.Add(this.dataGrid_Onay);
            this.tab_Onay.Location = new System.Drawing.Point(4, 29);
            this.tab_Onay.Name = "tab_Onay";
            this.tab_Onay.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Onay.Size = new System.Drawing.Size(1169, 723);
            this.tab_Onay.TabIndex = 1;
            this.tab_Onay.Text = "Onaylama";
            // 
            // cmb_Onay
            // 
            this.cmb_Onay.FormattingEnabled = true;
            this.cmb_Onay.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmb_Onay.Location = new System.Drawing.Point(93, 18);
            this.cmb_Onay.Name = "cmb_Onay";
            this.cmb_Onay.Size = new System.Drawing.Size(166, 28);
            this.cmb_Onay.TabIndex = 15;
            this.cmb_Onay.SelectedIndexChanged += new System.EventHandler(this.cmb_Onay_SelectedIndexChanged);
            // 
            // lbl_Onay
            // 
            this.lbl_Onay.AutoSize = true;
            this.lbl_Onay.Location = new System.Drawing.Point(8, 21);
            this.lbl_Onay.Name = "lbl_Onay";
            this.lbl_Onay.Size = new System.Drawing.Size(79, 20);
            this.lbl_Onay.TabIndex = 14;
            this.lbl_Onay.Text = "Onaylama:";
            // 
            // dataGrid_Onay
            // 
            this.dataGrid_Onay.AllowUserToAddRows = false;
            this.dataGrid_Onay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Onay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_Onay.Location = new System.Drawing.Point(3, 67);
            this.dataGrid_Onay.Name = "dataGrid_Onay";
            this.dataGrid_Onay.ReadOnly = true;
            this.dataGrid_Onay.RowHeadersWidth = 51;
            this.dataGrid_Onay.RowTemplate.Height = 29;
            this.dataGrid_Onay.Size = new System.Drawing.Size(1163, 653);
            this.dataGrid_Onay.TabIndex = 13;
            this.dataGrid_Onay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Onay_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.txt_RecycleFiyat);
            this.tabPage1.Controls.Add(this.txt_ToplamRecycle);
            this.tabPage1.Controls.Add(this.lbl_RecycleFiyat);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbl_Reycle);
            this.tabPage1.Controls.Add(this.dataGrid_Para);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 723);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            // 
            // txt_RecycleFiyat
            // 
            this.txt_RecycleFiyat.Location = new System.Drawing.Point(466, 227);
            this.txt_RecycleFiyat.Name = "txt_RecycleFiyat";
            this.txt_RecycleFiyat.ReadOnly = true;
            this.txt_RecycleFiyat.Size = new System.Drawing.Size(218, 27);
            this.txt_RecycleFiyat.TabIndex = 4;
            this.txt_RecycleFiyat.Text = "0";
            this.txt_RecycleFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ToplamRecycle
            // 
            this.txt_ToplamRecycle.Location = new System.Drawing.Point(466, 185);
            this.txt_ToplamRecycle.Name = "txt_ToplamRecycle";
            this.txt_ToplamRecycle.ReadOnly = true;
            this.txt_ToplamRecycle.Size = new System.Drawing.Size(218, 27);
            this.txt_ToplamRecycle.TabIndex = 3;
            this.txt_ToplamRecycle.Text = "0";
            this.txt_ToplamRecycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RecycleFiyat
            // 
            this.lbl_RecycleFiyat.AutoSize = true;
            this.lbl_RecycleFiyat.Location = new System.Drawing.Point(329, 230);
            this.lbl_RecycleFiyat.Name = "lbl_RecycleFiyat";
            this.lbl_RecycleFiyat.Size = new System.Drawing.Size(131, 20);
            this.lbl_RecycleFiyat.TabIndex = 2;
            this.lbl_RecycleFiyat.Text = "RecycleCoin Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // lbl_Reycle
            // 
            this.lbl_Reycle.AutoSize = true;
            this.lbl_Reycle.Location = new System.Drawing.Point(264, 188);
            this.lbl_Reycle.Name = "lbl_Reycle";
            this.lbl_Reycle.Size = new System.Drawing.Size(196, 20);
            this.lbl_Reycle.TabIndex = 0;
            this.lbl_Reycle.Text = "Toplam RecycleCoin Miktarı:";
            // 
            // dataGrid_Para
            // 
            this.dataGrid_Para.AllowUserToAddRows = false;
            this.dataGrid_Para.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Para.Location = new System.Drawing.Point(645, 233);
            this.dataGrid_Para.Name = "dataGrid_Para";
            this.dataGrid_Para.RowHeadersWidth = 51;
            this.dataGrid_Para.RowTemplate.Height = 29;
            this.dataGrid_Para.Size = new System.Drawing.Size(20, 17);
            this.dataGrid_Para.TabIndex = 5;
            this.dataGrid_Para.Visible = false;
            // 
            // timer1
            // 
            
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 756);
            this.Controls.Add(this.tab_CoinInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tab_CoinInfo.ResumeLayout(false);
            this.tab_List.ResumeLayout(false);
            this.tab_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kullanicilar)).EndInit();
            this.tab_Onay.ResumeLayout(false);
            this.tab_Onay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Onay)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Para)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_CoinInfo;
        private System.Windows.Forms.TabPage tab_List;
        private System.Windows.Forms.TextBox txt_Yas;
        private System.Windows.Forms.Label lbl_Yas;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.DataGridView dataGrid_Kullanicilar;
        private System.Windows.Forms.TabPage tab_Onay;
        private System.Windows.Forms.ComboBox cmb_KullaniciTurListele;
        private System.Windows.Forms.TextBox txt_Arama;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_Kulad;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Kulad;
        private System.Windows.Forms.ComboBox cmb_KullaniciTur;
        private System.Windows.Forms.Label lbl_KullaniciTur;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DataGridView dataGrid_Onay;
        private System.Windows.Forms.Button btn_KulSil;
        private System.Windows.Forms.ComboBox cmb_Onay;
        private System.Windows.Forms.Label lbl_Onay;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_ToplamRecycle;
        private System.Windows.Forms.Label lbl_RecycleFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Reycle;
        private System.Windows.Forms.TextBox txt_RecycleFiyat;
        private System.Windows.Forms.DataGridView dataGrid_Para;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Exit;
    }
}
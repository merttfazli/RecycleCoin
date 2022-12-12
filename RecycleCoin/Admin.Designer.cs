
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
            this.tab_CoinInfo = new System.Windows.Forms.TabControl();
            this.tab_List = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_CoinInfo.SuspendLayout();
            this.tab_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kullanicilar)).BeginInit();
            this.tab_Onay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tab_Onay.Controls.Add(this.dataGridView1);
            this.tab_Onay.Location = new System.Drawing.Point(4, 29);
            this.tab_Onay.Name = "tab_Onay";
            this.tab_Onay.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Onay.Size = new System.Drawing.Size(1169, 723);
            this.tab_Onay.TabIndex = 1;
            this.tab_Onay.Text = "Onaylama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 569);
            this.dataGridView1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 723);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Coin Bilgileri";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_KulSil;
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class Admin : Form
    {
        string kimlik;
        string transferid;
        int karbon;// boş bu evet boşmuş
        double recycle;// bu nerde doluyodu unuttum aq
        DateTime time;
        char onay;
        

        KullaniciProvider kul = new KullaniciProvider();
        RecycleProvider rec = new RecycleProvider();
        public Admin()
        {
            
            InitializeComponent();

            DatagridVeriEkle();
            DataGridAyar();
            TextDoldur();
            degiskendoldur();
        }
        
        public void DatagridVeriEkle()
        {
            dataGrid_Kullanicilar.DataSource = kul.kullaniciListele();
            dataGrid_Onay.DataSource = kul.AdminOnaylama();
            dataGrid_Para.DataSource = rec.RecycleBilgi();
            
        }
        double toplamRecycleCoin = 0.0;
        double RecycleFiyat;
        public void DataGridAyar()
        {
            dataGrid_Kullanicilar.Columns[0].HeaderText = "Ad";
            dataGrid_Kullanicilar.Columns[1].HeaderText = "Soyad";
            dataGrid_Kullanicilar.Columns[2].HeaderText = "Yaş";
            dataGrid_Kullanicilar.Columns[3].HeaderText = "Kullanıcı Adı";
            dataGrid_Kullanicilar.Columns[4].HeaderText = "Mail";
            dataGrid_Kullanicilar.Columns[5].HeaderText = "Telefon Numarası";
            dataGrid_Kullanicilar.Columns[6].HeaderText = "Kullanıcı Türü";
            dataGrid_Kullanicilar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Kullanicilar.Columns[0].Width = 180;
            dataGrid_Kullanicilar.Columns[1].Width = 168;
            dataGrid_Kullanicilar.Columns[2].Width = 80;
            dataGrid_Kullanicilar.Columns[3].Width = 168;
            dataGrid_Kullanicilar.Columns[4].Width = 205;
            dataGrid_Kullanicilar.Columns[5].Width = 168;
            dataGrid_Kullanicilar.Columns[6].Width = 140;
            dataGrid_Kullanicilar.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Kullanicilar.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Kullanicilar.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Kullanicilar.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Kullanicilar.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Kullanicilar.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Kullanicilar.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            dataGrid_Onay.Columns[0].HeaderText = "Transfer ID";
            dataGrid_Onay.Columns[1].HeaderText = "Kullanıcı Kimlik";
            dataGrid_Onay.Columns[2].HeaderText = "Mail";
            dataGrid_Onay.Columns[3].HeaderText = "Donusturulecek Karbon";
            dataGrid_Onay.Columns[4].HeaderText = "RecycleCoin";
            dataGrid_Onay.Columns[5].HeaderText = "İstek Tarihi";
            dataGrid_Onay.Columns[6].HeaderText = "Onay";
            dataGrid_Onay.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Onay.Columns[0].Width = 100;
            dataGrid_Onay.Columns[1].Width = 350;
            dataGrid_Onay.Columns[2].Width = 180;
            dataGrid_Onay.Columns[3].Width = 140;
            dataGrid_Onay.Columns[4].Width = 120;
            dataGrid_Onay.Columns[5].Width = 100;
            dataGrid_Onay.Columns[6].Width = 100;

            dataGrid_Onay.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Onay.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Onay.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Onay.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Onay.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Onay.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGrid_Onay.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        public void OnayDoldur()
        { 
            cmb_Onay.Text = dataGrid_Onay.CurrentRow.Cells[6].Value.ToString();
            transferid = dataGrid_Onay.CurrentRow.Cells[0].Value.ToString();
            kimlik = dataGrid_Onay.CurrentRow.Cells[1].Value.ToString();
            karbon = Convert.ToInt32(dataGrid_Onay.CurrentRow.Cells[3].Value.ToString());//bizbu adama bunu göstermezsek karbonu list yoluyla çekmemiz gerekiyor gösterelim onda sıkıntı yok bu işlenmemiş karbon dimi ? bak göstercem hangi karbon olduğunu
            time = DateTime.Now;// okey gibi
        }
        public void TextDoldur()
        {
            txt_ToplamRecycle.Text = dataGrid_Para.Rows[0].Cells[0].Value.ToString();// db den gelen veri bu toplam coin mi evet 10 mn olan
            
        }
        public async void degiskendoldur()
        {
            toplamRecycleCoin = Convert.ToDouble(txt_ToplamRecycle.Text);// txt gösterdim burda
        }
        private void dataGrid_Kullanicilar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Ad.Text = dataGrid_Kullanicilar.CurrentRow.Cells[0].Value.ToString();
            txt_Soyad.Text = dataGrid_Kullanicilar.CurrentRow.Cells[1].Value.ToString();
            txt_Yas.Text = dataGrid_Kullanicilar.CurrentRow.Cells[2].Value.ToString();
            txt_Kulad.Text = dataGrid_Kullanicilar.CurrentRow.Cells[3].Value.ToString();
            txt_Mail.Text = dataGrid_Kullanicilar.CurrentRow.Cells[4].Value.ToString();
            txt_Telefon.Text = dataGrid_Kullanicilar.CurrentRow.Cells[5].Value.ToString();
            cmb_KullaniciTur.SelectedIndex = int.Parse(dataGrid_Kullanicilar.CurrentRow.Cells[6].Value.ToString())-1;
            txt_Arama.Text = "";
        }

        private void txt_Arama_TextChanged(object sender, EventArgs e)
        {
            
            DataView dv = kul.kullaniciListele().DefaultView;
            dv.RowFilter ="Ad LIKE'" + txt_Arama.Text + "%'"; 
            dataGrid_Kullanicilar.DataSource = dv;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            kul.KullaniciAd = txt_Kulad.Text;
            kul.KullaniciTip = (cmb_KullaniciTur.SelectedIndex+1).ToString();
            if (kul.KullaniciTipGuncelleme(kul)==true)
            {
                MessageBox.Show("Kullanıcı Türü Güncellendi");
            }
            else
            {
                MessageBox.Show("Kullanıcı Türü Güncellenemedi");
            }
        }

        private void cmb_KullaniciTurListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            kul.KullaniciTip = (cmb_KullaniciTurListele.SelectedIndex + 1).ToString();
            dataGrid_Kullanicilar.DataSource = kul.KullaniciTipineGoreListele(kul);
        }

        private void btn_KulSil_Click(object sender, EventArgs e)
        {
            if (kul.KullaniciSil(txt_Kulad.Text))
            {
                MessageBox.Show("Kullanıcı Başarıyla Silindi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı Silinemedi.");
            }
        }

        private void dataGrid_Onay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnayDoldur();
        }
        private void cmb_Onay_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            if (cmb_Onay.SelectedIndex==1)
            {
                dialog = MessageBox.Show("Onaylamak İstediğinize Emin Misiniz?","Bilgilendirme",MessageBoxButtons.YesNo);
                if (dialog== DialogResult.Yes)
                {
                    onay = '1';
                    kul.TransferOnay(kimlik, transferid, time, onay);
                }
            }
            DatagridVeriEkle();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}

using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using ZXing;
namespace RecycleCoin
{
    public partial class Anasayfa : Form
    {
        public static string ad;
        public static string soyad;
        public static string mail;
        public static string telefon;
        public static int id;
        UrunProvider urunProvider = new UrunProvider();
        KullaniciProvider kul = new KullaniciProvider();
        public Anasayfa()
        {
            InitializeComponent();

            FotografYakala();
            KullaniciBilgileri();
            DatagridDoldur();
        }
        public void FotografYakala()
        {
            FilterInfoCollection webcam;
            VideoCaptureDevice cam;
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cam = new VideoCaptureDevice(webcam[0].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
            timer1.Start();
        }
        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pic_QrOkutma.Image = bit;
        }
        private void link_KulBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciBilgiGuncelleme kulbilgi = new KullaniciBilgiGuncelleme();
            kulbilgi.Show();
            this.Hide();
        }
        public void DataGridAyar()
        {
            data_VeriTutucu.Columns[0].HeaderText = "Ürünün Adı";
            data_VeriTutucu.Columns[1].HeaderText = "Ürünün Türü";
            data_VeriTutucu.Columns[2].HeaderText = "Ürünün Kodu";
            data_VeriTutucu.Columns[3].HeaderText = "Ürünün Karbon Miktarı";

            data_VeriTutucu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_VeriTutucu.Columns[0].Width = 188;
            data_VeriTutucu.Columns[1].Width = 120;
            data_VeriTutucu.Columns[2].Width = 185;
            data_VeriTutucu.Columns[3].Width = 190;
            data_VeriTutucu.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            data_VeriTutucu.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            data_VeriTutucu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            data_VeriTutucu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic_QrOkutma.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pic_QrOkutma.Image);
                if (sonuc != null)
                {
                    txt_UrunKodu.Text = sonuc.ToString();
                    BilgileriGetir(txt_UrunKodu.Text);
                    DataKontrol();
                    playSimpleSound();
                    FotografYakala();
                    timer1.Stop();
                    if (datagrid_Sepet.Rows.Count > 0)
                    {
                        dataGridBoyut();
                    }
                }
            }
            timer1.Start();
        }
        public void BilgileriGetir(string kod)
        {
            var veri = urunProvider.UrunleriListele().Find(x => (x.UrunKod == kod));
            if (veri != null)
            {
                txt_Urunad.Text = veri.UrunAd;
                txt_UrunTur.Text = veri.UrunTur.ToString();
                txt_KarbonMik.Text = veri.UrunKarbon.ToString();
            }
            else
            {
                MessageBox.Show("Bu koda ait ürün bulunamamıştır!");
            }
        }
        DataTable tablo = new DataTable();
        public void TexteDoldur()
        {
            txt_Urunad.Text = data_VeriTutucu.Rows[0].Cells[0].Value.ToString();
            txt_UrunTur.Text = data_VeriTutucu.Rows[0].Cells[1].Value.ToString();
            txt_UrunKodu.Text = data_VeriTutucu.Rows[0].Cells[2].Value.ToString();
            txt_KarbonMik.Text = data_VeriTutucu.Rows[0].Cells[3].Value.ToString();
        }
        int toplamKarbon = 0;
        double recycleCoin = 0;
        //public void DataVeriEkle()
        //{
        //    tablo.Rows.Add(txt_UrunKodu.Text, txt_Urunad.Text, txt_UrunTur.Text, int.Parse(txt_KarbonMik.Text));
        //    datagrid_Sepet.DataSource = tablo;
        //}
        public void ToplamKarbon()
        {

            datagrid_Sepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in datagrid_Sepet.Rows)
            {
                int deger = int.Parse(row.Cells[3].Value.ToString());
                toplamKarbon += deger;
            }
        }
        public void DataKontrol()
        {
            string[] yeni = { txt_UrunKodu.Text, txt_Urunad.Text, txt_UrunTur.Text, txt_KarbonMik.Text };
            if (datagrid_Sepet.Rows.Count == 0)
            {
                datagrid_Sepet.Rows.Add(yeni);

            }
            else
            {
                datagrid_Sepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow row in datagrid_Sepet.Rows)
                {
                    if ((row.Cells[0].Value.ToString().Equals(txt_UrunKodu.Text)) != true)
                    {
                        datagrid_Sepet.Rows.Add(yeni);
                    }
                    else
                    {
                        timer1.Stop();
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Ürün zaten sepette!", "UYARI", MessageBoxButtons.OK);
                        if (dialog == DialogResult.OK)
                        {
                            timer1.Start();
                        }
                    }
                }
            }
        }
        public void dataGridBoyut()
        {
            datagrid_Sepet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Sepet.Columns[0].Width = 150;
            datagrid_Sepet.Columns[1].Width = 280;
            datagrid_Sepet.Columns[2].Width = 200;
            datagrid_Sepet.Columns[3].Width = 190;
            datagrid_Sepet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        int karbontut;
        public void DatagridDoldur()
        {
            //id = int.Parse(dataGrid_Bilgi.Rows[0].Cells[0].Value.ToString());
            //lbl_Ad1.Text = dataGrid_Bilgi.Rows[0].Cells[1].Value.ToString();
            //lbl_Soyad1.Text = dataGrid_Bilgi.Rows[0].Cells[2].Value.ToString();
            //txt_KulAd.Text = dataGrid_Bilgi.Rows[0].Cells[4].Value.ToString();
            //txt_Mail.Text = dataGrid_Bilgi.Rows[0].Cells[5].Value.ToString();
            //txt_Telefon.Text = dataGrid_Bilgi.Rows[0].Cells[6].Value.ToString();
            //txt_KullaniciKimlik.Text = dataGrid_Bilgi.Rows[0].Cells[7].Value.ToString();
            //lbl_KarbonMikListe.Text = dataGrid_Bilgi.Rows[0].Cells[8].Value.ToString();
            karbontut = int.Parse(lbl_KarbonMikListe.Text);
            ad = lbl_Ad1.Text;
            soyad = lbl_Soyad1.Text;
            mail = txt_Mail.Text;
            telefon = txt_Telefon.Text;
        }
        private void timer_Ekle_Tick(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();


            dialog = MessageBox.Show("Ürün Sepete Eklendi !", "Bilgilendirme", MessageBoxButtons.OK);
            DataKontrol();
            dataGridBoyut();
            if (dialog == DialogResult.OK)
            {

            }
        }
        private void txt_UrunTur_TextChanged(object sender, EventArgs e)
        {
            if (txt_UrunTur.Text == "1")
            {
                txt_UrunTur.Text = "Plastik";
            }
            else if (txt_UrunTur.Text == "2")
            {
                txt_UrunTur.Text = "Alüminyum";
            }
            else if (txt_UrunTur.Text == "3")
            {
                txt_UrunTur.Text = "Kağıt";
            }
            else if (txt_UrunTur.Text == "4")
            {
                txt_UrunTur.Text = "Cam";
            }
            else if (txt_UrunTur.Text == "5")
            {
                txt_UrunTur.Text = "Demir";
            }
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\merts\Belgeler\GitHub\RecycleCoin\RecycleCoin\UrunSes\barkod.wav");
            simpleSound.Play();
        }
        public void KullaniciBilgileri()
        {
            KullaniciProvider kullaniciProvider = new KullaniciProvider();
            var kullanici = kullaniciProvider.kulList().Find(x => (x.KullaniciAd == LoginInfo.kulad));
            var bakiye = kullaniciProvider.cuzdanBilgileri().Find(x => (x.kullanici_ID == kullaniciProvider.SHA256Hash(kullanici.ID)));

            lbl_Ad1.Text = kullanici.ad;
            lbl_Soyad1.Text = kullanici.soyad;

            lbl_Miktar.Text = bakiye.coin_Miktari.ToString();
            lbl_KarbonMikListe.Text = bakiye.carbon_Miktari.ToString();

            txt_KullaniciKimlik.Text = bakiye.kullanici_ID;
            txt_KulAd.Text = kullanici.KullaniciAd;
            txt_Mail.Text = kullanici.mail;
            txt_Telefon.Text = kullanici.telefonNo;
           
        }
        private void btn_Donustur_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(toplamKarbon.ToString() + " Adet Karbonu Hesabınıza Ekliyorsunuz. Yapmak İstediğiniz Başka Bir İşlem Var Mı? ", "Bilgilendirme", MessageBoxButtons.YesNo);
            DataKontrol();
            dataGridBoyut();
            if (dialog == DialogResult.No)
            {
                karbontut += toplamKarbon;
                kul.KarbonEkle(karbontut, LoginInfo.kulad);
            }
            lbl_KarbonMikListe.Text = karbontut.ToString();
        }
        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_KullaniciKimlik.Text);
        }
        private void link_Donustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            DateTime tarih = DateTime.Now;
            if (karbontut < 100000)
            {
                MessageBox.Show("Dönüşüm Yapmak İçin Toplam Karbon Miktarınız 100.000 'den Fazla Olmalıdır. ");
            }
            else
            {
                if (kul.Transfer(txt_KullaniciKimlik.Text,mail,karbontut, recycleCoin, tarih))

                   dialog= MessageBox.Show(karbontut + " Adet Karbon Dönüşümü İçin Bilgi Geçildi En Kısa Sürede " + karbontut + " Karbona Eşit RecycleCoin Hesabınıza Yatırılacaktır.","Bilgilendirme !",MessageBoxButtons.OK);
                if (dialog==DialogResult.OK)
                {
                    karbontut = 0;
                    lbl_KarbonMikListe.Text = "0";
                    kul.KarbonEkle(karbontut, txt_KullaniciKimlik.Text);
                }

            }
        }
    }
}


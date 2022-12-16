using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
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
        

        int karbontut = 0;
        double recycleCoin = 0;

        UrunProvider urunProvider = new UrunProvider();
        KullaniciProvider kul = new KullaniciProvider();
        Donustur don = new Donustur();
        public Anasayfa()
        {
            InitializeComponent();
            don.FormClosed += new FormClosedEventHandler(don_FormClosed);
            //don.TheButton += new EventHandler(don_TheButtonClicked);
            FotografYakala();
            KullaniciBilgileri();
            DatagridDoldur();
        }
        void don_FormClosed(object sender, FormClosedEventArgs e)
        {
            lbl_KarbonMikListe.Text = "lalalasd";
        }
        //void don_TheButtonClicked(object sender, EventArgs e)
        //{
        //    lbl_KarbonMikListe.Text = "lalalasd";
        //}
        //TAB 1
        VideoCaptureDevice cam;
        FilterInfoCollection webcam;
        public void FotografYakala()
        {
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
        public void DataGridAyar()
        {
            datagrid_Sepet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Sepet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
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
                    timer1.Stop();
                    if(BilgileriGetir(txt_UrunKodu.Text))
                        DataKontrol();
                    if (datagrid_Sepet.Rows.Count > 0)
                    {
                        DataGridAyar();
                    }
                }
            }
            timer1.Start();
        }
        public bool BilgileriGetir(string kod)
        {
            var veri = urunProvider.UrunleriListele().Find(x => (x.UrunKod == kod) && (x.UrunDurum == true));
            if (veri != null)
            {
                txt_Urunad.Text = veri.UrunAd;
                txt_UrunTur.Text = veri.UrunTur.ToString();
                txt_KarbonMik.Text = veri.UrunKarbon.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Bu koda ait ürün bulunamamıştır!");
                txt_UrunKodu.Text = "";
                return false;
            }
            return false;
        }
        public void DataKontrol()
        {
            string[] yeni = { txt_UrunKodu.Text, txt_Urunad.Text, txt_UrunTur.Text, txt_KarbonMik.Text };
            if (datagrid_Sepet.RowCount < 1)
            {
                datagrid_Sepet.Rows.Add(yeni);
                playSimpleSound();
            }
            else
            {
                bool check = false;
                datagrid_Sepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow row in datagrid_Sepet.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txt_UrunKodu.Text)
                    {
                        check = true;
                    }
                    
                }
                if (!check)
                {
                    datagrid_Sepet.Rows.Add(yeni);
                }
                else
                {
                    MessageBox.Show("hata");
                }
            }
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\merts\Belgeler\GitHub\RecycleCoin\RecycleCoin\UrunSes\barkod.wav");
            simpleSound.Play();
        }
       

        private void btn_Donustur_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(ToplamKarbon().ToString() + " Adet Karbonu Hesabınıza Ekliyorsunuz. Yapmak İstediğiniz Başka Bir İşlem Var Mı? ", "Bilgilendirme", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                karbontut += ToplamKarbon();
                kul.KarbonEkle(karbontut, txt_KullaniciKimlik.Text);
                urunProvider.UrunDurumGuncelle(Kodlar());
                datagrid_Sepet.Rows.Clear();
                tab_Control.SelectedIndex = 1;
            }
            
            lbl_KarbonMikListe.Text = karbontut.ToString();
            
        }
        
        public string[] Kodlar()
        {
            string[] kods = new string[datagrid_Sepet.Rows.Count];
            for (int i = 0; i < datagrid_Sepet.Rows.Count; i++)
            {
                kods[i] = datagrid_Sepet.Rows[i].Cells[0].Value.ToString();
            }
            return kods;
        }
        //----------------------------------------------------------------------

        //TAB 2
        
        public void DatagridDoldur()
        {
            karbontut = int.Parse(lbl_KarbonMikListe.Text);
            ad = lbl_Ad1.Text;
            soyad = lbl_Soyad1.Text;
            mail = txt_Mail.Text;
            telefon = txt_Telefon.Text;
        }
        private void link_KulBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciBilgiGuncelleme kulbilgi = new KullaniciBilgiGuncelleme();
            kulbilgi.Show();
            this.Hide();
        }
        public int ToplamKarbon()
        {
            int toplamKarbon = 0;
            datagrid_Sepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in datagrid_Sepet.Rows)
            {
                int deger = int.Parse(row.Cells[3].Value.ToString());
                toplamKarbon += deger;
            }
            return toplamKarbon;
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
        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_KullaniciKimlik.Text);
        }
        private void link_Donustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Donustur donus = new Donustur();
            int carbon = int.Parse(lbl_KarbonMikListe.Text);
            if (carbon > 100000)
            {
                   donus.ShowDialog();
            }
            else
                MessageBox.Show("Dönüştürmek için yeterli Carbon(C)'a sahip değilsiniz!");
        }
        
        //----------------------------------------------------------------------

        //GENEL
        private void tab_Control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Control.SelectedIndex != 0)
            {
                cam.SignalToStop();
            }
            else
            {
                cam.Start();
            }
        }
    }
}


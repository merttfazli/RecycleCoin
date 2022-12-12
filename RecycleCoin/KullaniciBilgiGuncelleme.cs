using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class KullaniciBilgiGuncelleme : Form
    {
        public KullaniciBilgiGuncelleme()
        {
            InitializeComponent();
            BilgiGetir();
        }
        public void BilgiGetir()
        {
            txt_Ad.Text = Anasayfa.ad;
            txt_Soyad.Text = Anasayfa.soyad;
            txt_KulAd.Text = LoginInfo.kulad;
            txt_Mail.Text = Anasayfa.mail;
            txt_Telefon.Text = Anasayfa.telefon;
        }

        private void link_SifreGuncelleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreGuncelleme sifre = new SifreGuncelleme();
            sifre.Show();
            this.Hide();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            KullaniciProvider kul = new KullaniciProvider();
            DialogResult dialog = new DialogResult();
            kul.ad = txt_Ad.Text;
            kul.soyad = txt_Soyad.Text;
            kul.mail = txt_Mail.Text;
            kul.telefonNo = txt_Telefon.Text;
            kul.KullaniciAd = txt_KulAd.Text;
            if (kul.KullaniciBilgiGuncelleme(kul,Anasayfa.id)==true)
            {
                dialog = MessageBox.Show("Bilgileriniz Güncellendi ","Bilgilendirme",MessageBoxButtons.OK);
                if (dialog==DialogResult.OK)
                {
                    Giris gir = new Giris();
                    gir.Show();
                    this.Hide();
                }
            }
            
        }
    }
}

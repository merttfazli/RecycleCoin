using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace RecycleCoin
{       
    public partial class Giris : Form
    {
        KullaniciProvider k = new KullaniciProvider();
        RecycleProvider pro = new RecycleProvider();
        public Giris()
        {
            string system = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var userInfo = system.Split("\\");
            LoginInfo.pcName = userInfo[0];
            LoginInfo.userName = userInfo[1];

            InitializeComponent();
            txt_Kulad.Text = "samedtemiz";
            txt_Sifre.Text = "123456";
        }
        //Formu taşımak için
        Point lastPoint;
        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //--------------------------------------------------------------

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_Kulad.Text == "" || txt_Sifre.Text == "")
            {
                MessageBox.Show("Öncellikle Boşlukları Doldurmalısınız.");
            }
            else
            {
                //Giriş bilgileri doğru ise kullanıcı tipi dönüyor; yanlış ise 0 dönüyor
                var kul_tip = k.GirisKontrol(txt_Kulad.Text, txt_Sifre.Text);

                if (kul_tip != 0)//Kullanıcı bilgisi yanlış demek
                {
                    LoginInfo.kulad = txt_Kulad.Text;
                    LoginInfo.oturum = true;
                    switch (kul_tip)
                    {
                        case 1: //Admin sayfası
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                            break;
                        case 2: //Sorumlu sayfası
                            Urun urun = new Urun();
                            urun.Show();
                            this.Hide();
                            break;
                        case 3: //Kullanıcı sayfası
                            Anasayfa ana = new Anasayfa();
                            ana.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Bilgiler Hatalı");
                    txt_Sifre.Text = "";
                    txt_Kulad.Text = "";
                }
            }
        }
        private void link_Sifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            sifre.Show();
            this.Hide();
        }
        private void link_KayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.Show();
            this.Hide();
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            if (txt_Sifre.PasswordChar == '*')
            {
                btn_kapat.BringToFront();
                txt_Sifre.PasswordChar = '\0';
            }
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            if (txt_Sifre.PasswordChar == '\0')
            {
                btn_ac.BringToFront();
                txt_Sifre.PasswordChar = '*';
            }
        }
        private void btn_appStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }   
    }
}

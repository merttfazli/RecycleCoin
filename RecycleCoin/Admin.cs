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
    public partial class Admin : Form
    {
        KullaniciProvider kul = new KullaniciProvider();
        public Admin()
        {
            InitializeComponent();

            DatagridVeriEkle();
            DataGridAyar();
        }
        public void DatagridVeriEkle()
        {
            dataGrid_Kullanicilar.DataSource = kul.kullaniciListele();
        }
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RecycleCoin
{
    public class UrunProvider:Urunler
    {
        public UrunProvider()
        {
            Baglan();
        }
        public bool UrunEkle(Urunler urun)
        {
            int durum = 1;
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Urunler(UrunAd, UrunTur, UrunKod, UrunKarbon, UrunQrUrl)" + "Values('" + urun.UrunAd + "','" + urun.UrunTur + "','" + urun.UrunKod + "','" + urun.UrunKarbon + "','" + urun.QrUrl + "')", conn);
            durum=cmd.ExecuteNonQuery();
            conn.Close();
            if (durum == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool urunKontrol(string kod)
        {
            conn.Open();
            int durum = 1;
            cmd = new SqlCommand("SELECT Count(UrunKod) FROM Urunler WHERE UrunKod = '" + kod + "'", conn);
            durum = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (durum == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            

        }
        public List<Urunler> UrunleriListele()
        {
            List<Urunler> urun = new List<Urunler>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT UrunID, UrunAd, UrunTur, UrunKod, UrunKarbon, UrunQrUrl FROM Urunler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Urunler urunler = new Urunler();

                urunler.UrunID = int.Parse(dr[0].ToString());
                urunler.UrunAd = dr[1].ToString();
                urunler.UrunTur = int.Parse(dr[2].ToString());
                urunler.UrunKod = dr[3].ToString();
                urunler.UrunKarbon = int.Parse(dr[4].ToString());
                urunler.QrUrl = dr[5].ToString();
                urun.Add(urunler);
            }
            dr.Close();
            conn.Close();
            return urun;
        }
        public bool UrunleriGuncelle(int id, string urunad,int uruntur,string urunkod,int urunkarbon,string urunqr)
        {
            int durum = 1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Urunler set UrunAd='"+urunad+"', UrunTur='"+uruntur+"',Urunkod='"+urunkod+"',UrunKarbon='"+urunkarbon+"',UrunQrUrl='"+urunqr+"' where UrunID='"+id+"'", conn);
            durum= cmd.ExecuteNonQuery();
            conn.Close(); 
            if (durum==1)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
        public bool UrunSil(string urunkod)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM Urunler WHERE UrunKod='" +urunkod+ "'", conn);
            if (cmd.ExecuteNonQuery() != -1)
            {
                conn.Close();
                return  true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }
        public DataTable UrunDoldur(string kod)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select UrunAd,UrunTur,UrunKod,UrunKarbon from Urunler where UrunKod='" + kod + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
    }
}

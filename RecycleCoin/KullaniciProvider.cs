using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecycleCoin
{
    public class KullaniciProvider : Kullanicilar
    {
        public bool kontrolKullanici(string kulad)
        {
            conn.Open();
            bool result = false;
            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd = '" + kulad + "'", conn);
            var oku = cmd.ExecuteReader();
            
            if (oku.Read())
            {
                result = true;
            }
            else
            {
                result = false;
            }
            conn.Close();
            return result;
        }
        public int GirisKontrol(string kulad, string sifre)
        {
            cmd = new SqlCommand("SELECT KullaniciAd, Sifre, KullaniciTip FROM Kullanicilar WHERE KullaniciAd='" + kulad + "' AND Sifre= '" + sifre + "' ", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                return (int)oku[2];
            }
            conn.Close();
            return 0;
        }
        public bool KullaniciEkle(Kullanicilar kul)
        {
            bool result = false;
            if (!kontrolKullanici(kul.KullaniciAd))
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Kullanicilar(KullaniciID,Ad, Soyad, Yas, KullaniciAd, Sifre, Mail, TelefonNumarasi,Sha) VALUES ('"+kul.ID+"','" + kul.ad + "', '" + kul.soyad + "', '" + kul.yas + "', '" + kul.KullaniciAd + "', '" + kul.sifre + "', '" + kul.mail + "', '" + kul.telefonNo + "','"+SHA256Hash(kul.ID.ToString())+"')", conn);

                if (cmd.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
            }
            conn.Close();
            return result;
        } 
        public DataTable kullaniciListele()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Ad,Soyad,Yas,KullaniciAd,Mail,TelefonNumarasi,KullaniciTip from Kullanicilar", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public bool KullaniciTipGuncelleme(Kullanicilar kul)
        {
            int durum = 1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET KullaniciTip='"+kul.KullaniciTip+"' where KullaniciAd='"+kul.KullaniciAd+"'", conn);
            durum = cmd.ExecuteNonQuery();
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
        public DataTable KullaniciTipineGoreListele(Kullanicilar kul)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Ad,Soyad,Yas,KullaniciAd,Mail,TelefonNumarasi,KullaniciTip from Kullanicilar where KullaniciTip='"+kul.KullaniciTip+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;

        }
        public bool KontrolMail(Kullanicilar kul)
        {
            bool durum = false;
           
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar where Mail='"+kul.mail+"'", conn);
            conn.Open();
            SqlDataReader oku= cmd.ExecuteReader();
            if (oku.Read())
            {
                durum = true;
                conn.Close();
            }
            else
            {
                durum = false;
                conn.Close();
            }
            return durum;
            
        }
        public bool SifreGuncelleme(Kullanicilar kul)
        {
            int durum = 1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Sifre='" + kul.sifre + "' where KullaniciAd='" + kul.KullaniciAd + "'", conn);
            durum = cmd.ExecuteNonQuery();
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
        public DataTable bilgiDoldur(Kullanicilar kul)
        {
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select KullaniciID,Ad,Soyad,Yas,KullaniciAd,Mail,TelefonNumarasi,Sha,ToplamKarbon from Kullanicilar where KullaniciAd='"+kul.KullaniciAd+"'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                da.Dispose();
                return dt;
        }
        public bool KullaniciBilgiGuncelleme(Kullanicilar kul,int id)
        {
            int durum = 1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Ad='"+kul.ad+"', Soyad='"+kul.soyad+"' , KullaniciAd='"+kul.KullaniciAd+"', Mail='"+kul.mail+"', TelefonNumarasi='"+kul.telefonNo+"' where KullaniciID='" + id + "'", conn);
            durum = cmd.ExecuteNonQuery();
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
        public string SHA256Hash(string text)
        {
            string source = text;
            using (SHA256 sha1Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }
        public DataTable IDCek()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select KullaniciID from Kullanicilar", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public bool KarbonEkle(int karbon,string kulad)
        {
            bool result = false;
                conn.Open();
                cmd = new SqlCommand("Update Kullanicilar Set ToplamKarbon=('"+karbon+"') where KullaniciAd='"+kulad+"'", conn);

                if (cmd.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
            conn.Close();
            return result;
        }

        public bool KullaniciSil(string kulad)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("Delete From Kullanicilar where KullaniciAd='" + kulad + "'", conn);

            if (cmd.ExecuteNonQuery() != -1)
            {
                result = true;
            }
            conn.Close();
            return result;
        }

    }
}

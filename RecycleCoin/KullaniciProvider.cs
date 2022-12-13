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
                cmd = new SqlCommand("INSERT INTO Kullanicilar(KullaniciID, Ad, Soyad, Yas, KullaniciAd, Sifre, Mail, TelefonNumarasi) VALUES ('" + kul.ID + "','" + kul.ad + "', '" + kul.soyad + "', '" + kul.yas + "', '" + kul.KullaniciAd + "', '" + kul.sifre + "', '" + kul.mail + "', '" + kul.telefonNo + "')", conn);

                if (cmd.ExecuteNonQuery() != -1)
                {
                    if (CuzdanOlustur(kul.ID))
                    {
                        return true;
                    }
                }
            }
            conn.Close();
            return result;
        }
        public List<Kullanicilar> kulList()
        {
            List<Kullanicilar> kullanici = new List<Kullanicilar>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select KullaniciID, Ad, Soyad, Yas, KullaniciAd, Sifre, Mail, TelefonNumarasi, KullaniciTip from Kullanicilar", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kullanicilar kul = new Kullanicilar();

                kul.ID = dr[0].ToString();
                kul.ad = dr[1].ToString();
                kul.soyad = dr[2].ToString();
                kul.yas = int.Parse(dr[3].ToString());
                kul.KullaniciAd = dr[4].ToString();
                kul.sifre = dr[5].ToString();
                kul.mail = dr[6].ToString();
                kul.telefonNo = dr[7].ToString();
                kul.KullaniciTip = dr[8].ToString();
                kullanici.Add(kul);
            }
            dr.Close();
            conn.Close();
            return kullanici;

        }
        public List<Cuzdan> cuzdanBilgileri()
        {
            List<Cuzdan> para = new List<Cuzdan>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cuzdan", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cuzdan cuz = new Cuzdan();
                cuz.cuzdan_ID = int.Parse(dr[0].ToString());
                cuz.kullanici_ID = dr[1].ToString();
                cuz.carbon_Miktari = int.Parse(dr[2].ToString());
                cuz.coin_Miktari = Convert.ToDouble(dr[3].ToString());
                para.Add(cuz);
            }
            return para;
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
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET KullaniciTip='" + kul.KullaniciTip + "' where KullaniciAd='" + kul.KullaniciAd + "'", conn);
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
            SqlCommand cmd = new SqlCommand("Select Ad,Soyad,Yas,KullaniciAd,Mail,TelefonNumarasi,KullaniciTip from Kullanicilar where KullaniciTip='" + kul.KullaniciTip + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;

        }
        public bool KontrolMail(Kullanicilar kul)
        {
            bool durum = false;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar where Mail='" + kul.mail + "'", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();
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
        public bool KullaniciBilgiGuncelleme(Kullanicilar kul, int id)
        {
            int durum = 1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Ad='" + kul.ad + "', Soyad='" + kul.soyad + "' , KullaniciAd='" + kul.KullaniciAd + "', Mail='" + kul.mail + "', TelefonNumarasi='" + kul.telefonNo + "' where KullaniciID='" + id + "'", conn);
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
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                return hash.ToLower();
            }
        }
 
        public bool KarbonEkle(int karbon, string kulID)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("Update Cuzdan Set Carbon+=('" + karbon + "') where Kullanici_ID='" + kulID + "'", conn);
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
        public string IdOlustur()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];//id
            var random = new Random();
            var pin = "";

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
                pin += stringChars[i];
            }
            return pin;
        }
        public bool CuzdanOlustur(string id)
        {
            string hash = SHA256Hash(id);
            cmd = new SqlCommand("INSERT INTO Cuzdan(kullanici_ID) VALUES ('" + hash + "')", conn);
            if (cmd.ExecuteNonQuery() != -1)
                return true;
            return false;
        }
        public bool Transfer(string sha, string mail,int karbon, double RecycleCoin, DateTime date)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Transfer(KullaniciKimlik,Mail,Karbon, RecycleCoin, IstekTarihi) VALUES ('" + sha + "','"+mail+"','" + karbon + "', '" + RecycleCoin + "', '" + date + "')", conn);

            if (cmd.ExecuteNonQuery() != -1)
            {
                result = true;
            }
            conn.Close();
            return result;
        }

        public DataTable AdminOnaylama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select TransferID, KullaniciKimlik, Mail, Karbon, RecycleCoin, IstekTarihi,Onay from Transfer where Onay='0'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public void TransferOnay(string kimlik, string transferid, DateTime onayTar, char onay)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("Update Transfer Set DonusumTarihi=('" + onayTar + "'), Onay=('" + onay + "') where TransferID='" + transferid + "'", conn);
            if (cmd.ExecuteNonQuery() != -1)
            {
                conn.Close();
                Cuzdan(kimlik);
            }
        }
        public void Cuzdan(string kimlik)
        {
            bool result = false;
            RecycleProvider rc = new RecycleProvider();//bu karbon hiç çekilmedi mi şimdi
            conn.Open();
            cmd = new SqlCommand("UPDATE Cuzdan SET Coin = 0, RecycleCoin+= '"+rc.RecycleCoinHesapla(karbon)+"' WHERE kullanici_ID='" + kimlik + "'", conn);
            
            if (cmd.ExecuteNonQuery() != -1)
            {
                result = true;
            }
            conn.Close();
        }   

        
    }
}

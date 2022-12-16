using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;

namespace RecycleCoin
{
    class TransferProvider : Transfer
    {
        public List<Transfer> TransferListele()
        {
            List<Transfer> transfer = new List<Transfer>();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Transfer", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Transfer tra = new Transfer();
                tra.TransferID = int.Parse(dr[0].ToString());
                tra.KullaniciKimlik = dr[1].ToString();
                tra.Karbon = int.Parse(dr[2].ToString());
                tra.Coin = Convert.ToDouble(dr[3].ToString());
                tra.istekTarihi = Convert.ToDateTime(dr[4].ToString());
                tra.onayTarihi = Convert.ToDateTime(dr[5].ToString());
                tra.Onay = Convert.ToBoolean(dr[6].ToString());
                transfer.Add(tra);
            }
            conn.Close();
            return transfer;
        }

        public bool TransferIstek(string sha, int karbon, double coin, DateTime date)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Transfer(KullaniciKimlik, Karbon, RecycleCoin, IstekTarihi) VALUES ('" + sha + "','" + karbon + "', @coin, '" + date + "')", conn);
            cmd.Parameters.AddWithValue("@coin", coin);

            SqlCommand cuzdanUpd = new SqlCommand("UPDATE Cuzdan SET Carbon -= '" + karbon + "' WHERE kullanici_ID= '" + sha + "'", conn);

            if (cmd.ExecuteNonQuery() != -1)
            {
                cuzdanUpd.ExecuteNonQuery();
                result = true;
            }
            conn.Close();
            return result;
        }

        public bool TransferOnay(string transferid, string kimlik, DateTime onayTar, char onay)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE Transfer SET DonusumTarihi=('" + onayTar + "'), Onay=('" + onay + "') WHERE TransferID='" + transferid + "' AND KullaniciKimlik = '"+kimlik+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}

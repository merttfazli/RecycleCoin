using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleCoin
{
    class Transfer : Database
    {
        public int TransferID { get; set; }
        public string KullaniciKimlik { get; set; }
        public int Karbon { get; set; }
        public double Coin { get; set; }
        public DateTime istekTarihi { get; set; }
        public DateTime onayTarihi { get; set; }
        public bool Onay { get; set; }

        public Transfer()
        {
            Baglan();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSepet_3.CustomTools
{
    public class CartItem
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short Amount { get; set; } //Kac Adet alındıgı
        public decimal? SubTotal { get { return UnitPrice * Amount; } } //ara toplam

        public CartItem()
        {
            Amount++;
        }
    }
}
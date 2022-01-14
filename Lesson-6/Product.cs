using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    public class Product
    {
        public string Name;
        public double Price;
        public double DisCountPrice;
        public string  Code;
        public static int No = 100;
        public double NewPrice;
        public double TotalPrice;
        public int Count; //anbara verilen count
        public int SellCount; //musteri alan count

        public Product(string name,double price,double discount,int count)
        {
            Name = name;
            Price = price;
            DisCountPrice = discount;
            string x = name.Substring(0, 1); //K
            No++; //101
            Code = x + No;
            Count = count;
            GetTotalPrice();
        }

        public double GetTotalPrice()
        {
            double faiz = (Price * DisCountPrice) / 100; 
            this.NewPrice = Price - faiz; 
            return NewPrice;
        }

        public double Buy(int sellcount)
        {
            TotalPrice = sellcount * NewPrice;
            return TotalPrice;
        }

    }
}

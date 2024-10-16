using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation4
{
    public class Product
    {
        double _price;
        int _count;
        public double  Price { get { return _price; } set 
            {
                if (value > 0&&value < 100) { _price = value; }
                else { Console.WriteLine("Qiymet verilen qiymet araligin asir !"); }
            } }
        public  int Count  { get { return _count; } set { if (value > 0 && value < 999) { _count = value; } else { Console.WriteLine("Say verilen say araligin asir !"); } } }
        public string name;
        public int no;

        public Product(double price,  string name, int no)
        {
            Price = price;
            
            this.name = name;
            this.no = no;
        }
    }
}


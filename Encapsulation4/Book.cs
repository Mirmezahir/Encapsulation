using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation4
{
    internal class Book:Product
    {
        public string Genre;

        public Book(double price,  string name, int no,string genre):base (price,  name,no)
        {
            Genre = genre;
        }

        public void Showinfo() { Console.WriteLine($"Name:{name} Price:{Price}  No:{no} Genre:{Genre}"); }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation4
{
    internal class Library
    {
        public Book[] Books = new Book[0];
       public void AddBook(Book book) 
        {
            Book[] Newbooks = new Book[Books.Length+1];
            for (int i = 0; i < Books.Length; i++)
            {
                Newbooks[i]=Books[i];
            }
            Newbooks[Newbooks.Length - 1] = book;
            Books = Newbooks;
        
        }
       public void GetFilteredBooks(string genre) 
        {
            Book[] FilteredBooks = new Book[0];
            for (int i = 0;i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Array.Resize(ref FilteredBooks, +1);
                    FilteredBooks[FilteredBooks.Length-1] = Books[i];
                     
                }
            }
            foreach (Book book in FilteredBooks)
            {
                Console.WriteLine(book.name);
            }
        
        }
       public void GetFilteredBooks(double minPrice, double maxPrice) 
        {
            Book[] FilteredBooks = new Book[0];
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                {
                    Array.Resize (ref FilteredBooks,+1);
                    FilteredBooks [FilteredBooks.Length-1] =Books[i];
                }
            }
            for (int i = 0;i<FilteredBooks.Length ; i++)
            {
                Console.WriteLine(FilteredBooks[i]);
            }
        
        }

       public void ShowAllBooks() 
        {
            foreach (Book book in Books) { Console.WriteLine(book.no+"."+book.name); }
        
        }


    }
}

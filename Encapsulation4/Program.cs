namespace Encapsulation4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(10,"Suc ve ceza",1,"Roman");
            Book book2 = new Book(9, "Jasmin", 2, "Ask");
            Book book3 = new Book(5, "Yeraltindan notlar", 3, book1.Genre);
            Book book4 = new Book(15, "Gurur ve Onyargi", 4, book2.Genre);
            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            Console.WriteLine("       1[ADD BOOK]    2[SEARCH BOOK]");
            Console.Write("Ne etmek istediyiniz reqemle gosterin(1,2) :");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Asagida gosterilen deyerleri teyin edin");
                Console.Write("Kitab adi : ");
                string bookname = Convert.ToString(Console.ReadLine());
                bookname.Trim();
                Console.Write("Kitab qiymeti : ");
                double bookprice = Convert.ToDouble(Console.ReadLine());
                Console.Write("Kitab janri :");
                string bookgenre = Convert.ToString(Console.ReadLine());
                bookgenre.Trim();
                Console.Write("Kitab no : ");
                int bookno = Convert.ToInt32(Console.ReadLine());
                Book book = new Book(bookprice, bookname, bookno, bookgenre);
                library.AddBook(book);
                Console.WriteLine("Kitabiniz elave edildi");
                Console.WriteLine("Butun kitablarin siyahisini gormek isteyirsiniz");
                Console.WriteLine("   1[YES]    2[NO] ");
                Console.Write("Seciminiz : ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    library.ShowAllBooks();
                }
                else if (b == 2)
                {
                    return;
                }
                else return;
            }
            else if (a == 2)
            {
                Console.WriteLine("     1[SEARCH BY PRICE]   2[SEARCH BY GENRE]");
                Console.Write("Seciminiz :");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    Console.Write(" Min qiymet daxil edin : ");
                    double bookminprice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Max qiymet daxil edin : ");
                    double bookmaxprice = Convert.ToDouble(Console.ReadLine());
                    library.GetFilteredBooks(bookminprice, bookmaxprice);


                }
                else if (c == 2)
                {
                    Console.Write("Janr daxil edin(Ask,Roman) : ");
                    string bookgenre = Convert.ToString(Console.ReadLine());
                    bookgenre.Trim();
                    library.GetFilteredBooks(bookgenre);
                }
                 


            }
            else return;
            
            
        }
    }
}

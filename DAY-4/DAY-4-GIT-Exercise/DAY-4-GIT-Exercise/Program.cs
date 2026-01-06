using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_GIT_Exercise
{
    public class Book
    {
        public int id;
        public string title;
        public bool IsBorrowed;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Managelibrary library=new Managelibrary();
            library.Addbook(new Book { id=1,title="metamorphosis",IsBorrowed=false});
            library.Addbook(new Book { id = 2, title = "red rising", IsBorrowed = true });
            library.Addbook(new Book { id = 3, title = "goldenking", IsBorrowed = true });
            library.Addbook(new Book { id = 4, title = "crime", IsBorrowed = false });
            library.Addbook(new Book {id=5,title="witcher",IsBorrowed= false});


            library.BoorowBook(1);
            library.ReturnBook(2);
            library.ListallAvailableBooks();

      
        }
    }
}

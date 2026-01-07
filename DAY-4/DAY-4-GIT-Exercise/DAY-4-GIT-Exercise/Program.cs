using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
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


            

            bool run = true;
            while (run)
            {
                Console.WriteLine("1.AddBook");
                Console.WriteLine("2.list all available books");
                Console.WriteLine("3.borrow book");
                Console.WriteLine("4.return a book");
                Console.WriteLine("enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter book id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter book title");
                        string title = Console.ReadLine();

                        library.Addbook(new Book
                        {
                            id = id,
                            title = title,
                            IsBorrowed = false
                        });
                        Console.WriteLine("book added");
                        break;
                    case 2:
                        Console.WriteLine("\n available books");
                        library.ListallAvailableBooks();
                        break;
                    case 3:
                        Console.WriteLine("enter book id to borrow");
                        int borrowId = Convert.ToInt32(Console.ReadLine());
                        library.BoorowBook(borrowId);
                        break;
                    case 4:
                        Console.WriteLine("enter book id to return");
                        int returnID = Convert.ToInt32(Console.ReadLine());
                        library.ReturnBook(returnID);
                        break;
                    default:
                        Console.WriteLine("invalid choice try again");
                        break;
                }
                Console.WriteLine("do you want to exit the operation or not?\n yes or no type");
                string yes_no = Console.ReadLine();
                if (yes_no == "yes")
                {
                    run = false;
                }
            }
            


        }
    }
}

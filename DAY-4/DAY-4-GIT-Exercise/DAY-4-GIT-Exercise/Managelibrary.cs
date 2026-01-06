using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_GIT_Exercise
{
    public class Managelibrary //manages books and action on it
    {
        public List<Book> books=new List<Book>();
        
        public void Addbook(Book book)
        {
            //“This method expects ONE Book object and will call it book inside the method
            //Book is a class and book is an object
            books.Add(book);
        }
        public void ListallAvailableBooks()
        {
            foreach (var book in books)
            {
                if (!book.IsBorrowed)
                {
                    Console.WriteLine(book.title);
                    //checks if the book is not borrowed and tells us
                }
            }
        }
        public void BoorowBook(int id)
        {
            foreach (var book in books)
            {
                if (book.id == id && !book.IsBorrowed)//book.id == id: It checks if the ID tag on the book matches the one you are looking for.
                {
                    //chrckd id this book with th given id and if it is borrowed or not
                    book.IsBorrowed = true;
                    Console.WriteLine($"{book.title}is borrowed");
                    return;//once book is found we can just return instead of wasting time 
                }
                
            }
            Console.WriteLine("book not available");

        }
        public void ReturnBook(int id)
        {
            foreach (var book in books)
            {
                if(book.id == id && book.IsBorrowed)
                {
                    book.IsBorrowed = false;
                    Console.WriteLine($"{book.title} returned");
                    return;
                }
                
            }
            Console.WriteLine("invalid return");

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_Practice
{
    //using lists with custom objects

    public class Contact
    {
        public string Name {  get; set; }
        public string PhoneNumber { get; set; }

    }
    //applying models step-1 create the model
    public class contact
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // applying concept of llist and ts creation
            List<string> fruits=new List<string>();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");

            foreach(var fruit in fruits){
                Console.WriteLine(fruit);
            }
            //accesing items
            string firstfruit = fruits[0];
            Console.WriteLine(firstfruit);

            //removing items
            fruits.Remove("cherry"); // or fruits.RemoveAT(3);
            // both are valid ways to remove items in list
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            //adding items to list directly 
            
            List<string> cololrs = new List<string> { "RED", "BLUE", "PURPLE" };
            foreach (var colo in cololrs) { Console.WriteLine(colo); }
            Console.WriteLine();

            //performing operations on list like adding removing etc
            List<int> scores = new List<int> { 10, 20, 30 };
            scores.Add(40);
            foreach (int score in scores) { Console.WriteLine(score); }
            Console.WriteLine();
            scores.RemoveAt(1);
            foreach (int score in scores) { Console.WriteLine(score); }

            //finding items in a list
            bool contain=scores.Contains(30);
            Console.WriteLine(contain); //returns true since 30 is present
            int index_30 = scores.IndexOf(30);
            Console.WriteLine(index_30);//returns index of the item stored in list

            Console.WriteLine();
            //sorting
            scores.Sort();//puts numbers in ascending order and string in alphabetical order
            foreach (int score in scores) { Console.WriteLine(score); }
            scores.Reverse();//flips order of list 
            foreach (int score in scores) { Console.WriteLine(score); }

            //creating lists with custom objects 
            List<Contact> myfriends=new List<Contact>();
            Contact friend1=new Contact();
            friend1.Name = "alice";
            friend1.PhoneNumber= "1234567890";

            //adding it to the lists
            myfriends.Add(friend1);
            //shorthand method for object initializer
            myfriends.Add(new Contact { Name = "Bob",PhoneNumber="45434219"});
            myfriends.Add(new Contact { Name = "charlie", PhoneNumber = "5452343432" });

            //accesing data
            Console.WriteLine(myfriends[0].Name);
            Console.WriteLine(myfriends[0].PhoneNumber);
            Console.WriteLine(myfriends[1].Name);
            Console.WriteLine(myfriends[1].PhoneNumber) ;
            Console.WriteLine();

            //using find
            Contact mysteryperson = myfriends.Find(f => f.Name == "charlie");
            Console.WriteLine($"{mysteryperson.Name}'s number is{mysteryperson.PhoneNumber}");
            Console.WriteLine();

            //lopping over the list
            foreach(Contact friend in myfriends){
                Console.WriteLine($"{friend.Name}:{friend.PhoneNumber}");
            }
            // you can also use for(int i=0;i<myfirnds.count;i++)loop if you want to make any changes

            //using simple loop to find item using a specific id 
            string targetName = "1234567890";
            Contact foundfreind = null;
            foreach(Contact friend in myfriends)
            {
                if (friend.PhoneNumber == targetName)
                {
                    foundfreind = friend;
                    break;//stop looking once we find her
                }
            }
            Console.WriteLine(foundfreind.PhoneNumber);

            //using contactmanager.cs
            ContactManager manager = new ContactManager();
            manager.MyFriends.Add(new contact { id = 1, Name = "kshitij" });
            manager.MyFriends.Add(new contact { id = 2, Name = "jay" });

            //using logic from the other class
            contact found = manager.findbyname("kshitij");
            if (found != null)
            {
                Console.WriteLine("name found is:" + found.Name);
            }

        }
    }
}

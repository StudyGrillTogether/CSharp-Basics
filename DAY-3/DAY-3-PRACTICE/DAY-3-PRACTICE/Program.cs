using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DAY_3_PRACTICE
{
    class car
    {
        public string model;

        public car()// using constructor
        {
            model = "mustang";

        }
    }
    class car1 //using parametrized constructor and multiples
    {
        public string model;
        public string color;
        public int year;
        public car1(string model, string color, int year)
        {
            if(string.IsNullOrWhiteSpace(model)|| string.IsNullOrWhiteSpace(color)){
                throw new ArgumentException("name cannot be empty"); //use of validation in constructors
            }
            this.model = model;
            this.color = color;
            this.year = year;
        }
        
    }
    class person
    {
        private string name; //hidden data
        public string Name //controlled access
        {
            get { return name; }
            set { name = value; }
        }
    }
    public class Bank
    {
        //hiding class data by declaring the variable as private
        private double balance;
        //creating pblic setter and getter methods
        //public getter method is used to return the the data stored in balance variable or field
        public double getbalance()
        {
            return balance;
        }
        //public setter method is used to set data in balance variable
        public void setbalance(double balance)
        {
            if (balance >= 0)
            {
                this.balance = balance;
            }
            else
            {
                throw new Exception("please pass a positive value");//generic exception unlike argument exception
                // used for general errors when doesn't meet specific types 
            }

            
        }
        
    }
   //implementing data encapusulation using c#properties
    class bank
    {
        private double amount;
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                // validate the vale before storing it 
                if (value < 0)
                {
                    throw new Exception("please pass a positive value");
                }
                else
                {
                    amount=value;
                }
            }
        }
    }
    //understanding static vs nonstatic
    class Example
    {
        public int x; //Non static variable //x belongs to each object
        public static int y = 200; //y belongs to the class itsel
        public Example(int x)
        {
            this.x = x;
        }
        static void Add(int x)
        {
            //this is a static block 
            // we can access non static members x with the help of object only 
            //with the help of class name
       
            Console.WriteLine("sum of 100 and 200 is:"+x+Example.y);
        }
    }

    internal class Program
        {
        static void Main(string[] args)
        {

            car ford = new car();
            Console.WriteLine(ford.model);
            car1 mercedes = new car1("benz", "blue", 5);
            car1 ford1 = new car1("mustang", "red", 56);
            Console.WriteLine(mercedes.model + mercedes.color + mercedes.year);
            person person1=new person();
            person1.Name = "liam";
            Console.WriteLine(person1.Name);
            Bank bank=new Bank();
            // you cannot access the private ariable 
            //bank.balance will give compile time eroor
            // you can access private varaible via public setter and getter
            bank.setbalance(500);
            Console.WriteLine(bank.getbalance());
            //Bank bank1=new Bank();
            //bank1.setbalance(-200); gives an exception error due to -ve balance
            bank Bank = new bank();
            //we cannot access the amount variable directly
            //Bank.amout gives error since we are using properties for encapsulation
            //that is why we use public Amount property
            Bank.Amount = 1000;
            Console.WriteLine(Bank.Amount);
            //if we wrote negative it gives an error

            //accessing static variable using class name
            //before object creation
            Console.WriteLine($"Static Variable Y={Example.y}");
            //accessing the static variable without using class name
            //its possible cuz we are accessing the vatiable from same class
            // Console.WriteLine($"static varaible Y={y}"); you cannot access this since in different class
            //static vs non static
            Example obj1 = new Example(50);
            Example obj2 = new Example(100);//hence each object gets its own x
            Console.WriteLine(obj1.x + Example.y);

            
            }
        }
    
}

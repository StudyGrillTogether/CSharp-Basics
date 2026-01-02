using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


namespace DAY_1_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helloworld");
            Console.WriteLine("I'm learing c#");
            Console.WriteLine(3 + 3);
            Console.Write("LINKIN.");
            Console.Write("PARK \n");
            Console.WriteLine("dare");
            // Difference between write and writeline is that write doesnt autommatically go to next line
            /* for multiple line comments*/
            int x = 10;
            Console.WriteLine(x);
            string name;
            name = "wankar";
            Console.WriteLine(name);
            char myLetter = 'D';
            Console.WriteLine(myLetter);
            bool myBool = true; 
            Console.WriteLine(myBool);
            //concatenation string
            string first_name = "kshitij";
            string last_name = "wankar";
            name=first_name+last_name;
            Console.WriteLine(name);
            Console.WriteLine(string.Concat(first_name, last_name));
            // using substrings
            int charpos = name.IndexOf("w");
            string lname = name.Substring(charpos);
            Console.WriteLine(lname);
            // like above you can do same for integers
            int num1, num2, num3;
            num1 = 20;
            num2 = 30;
            num3 = 40;
            Console.WriteLine(num1 + num2 + num3);
            long mynum = 9223372036854775807L;
            Console.WriteLine(mynum);
            float f1 = 35e3F;
            Console.WriteLine(f1);

            //implicit casting or automatic casting
            int myInt = 9;
            double MyDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(MyDouble);
            // explicit casting or manual casting

            double MYDouble = 9.56;
            int MYint=(int)MyDouble;
            Console.WriteLine(MYint);
            Console.WriteLine(MYDouble);

            //automatic conversion methods
            double my_double = 9.43;
            bool my_bool = true;
            Console.WriteLine(Convert.ToInt32(my_bool));
            Console.WriteLine(Convert.ToInt32(my_double));
            //input
            Console.WriteLine("enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("username is:" + userName);
            // for int 
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is "+age);
            Console.WriteLine("enter your year");
            int year = Convert.ToInt32(Console.ReadLine());
            //task 1
            Console.WriteLine("the sum of age and year is:"+(age+year));
            //using switch
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            //using while
            int q = 4;
            while (q > 0)
            {
                Console.WriteLine("hello");
                q -= 1;
            }
            //do while loop
            int k = 0;
            do
            {
                Console.WriteLine("hello");
            }
            while(k > 0);//only executes once
            // task 2
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            //nested loops
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // executes 6 times (2 x 3)
                }
            }
            //using for each
            string[] cars = { "ford", "volvo", "bmw", "mazda" };
            foreach(string s in cars)
            {
                Console.WriteLine(s);
            }
            //using break 
            for(int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("using continue statement");
            //continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            MyMethod();
            Console.WriteLine("enter the number to check if its even or not");
            int even_odd = Convert.ToInt32(Console.ReadLine());
            IsEven(even_odd);

            //using return value methods
            int Z1 = MyMethod2(3);
            Console.WriteLine(Z1);

            //using named args
            Namedarg(child3:"john",child1:"lola",child2:"aster");

            //using method overloading
            Console.WriteLine("double is:"+PlusMethodInt(5, 6));
            Console.WriteLine("int is:"+PlusMethoddouble(4.6,2.3));
        }
        // using methods 
        static void MyMethod()
        {
            Console.WriteLine("i just got executed");
        }
        //task 3 using parameters and passing an argument
        static void IsEven(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
        static int MyMethod2(int x)
        {
            return 5 + x;
        }
        // named arguments 
        static void Namedarg(string child1,string child2,string child3)
        {
            Console.WriteLine("the youngest child is :"+child3);
        }
         static int PlusMethodInt(int n,int m)
        {
            return n + m;
        }
        static double PlusMethoddouble(double n,double m)
        {
            return n + m;
        }
    }

}

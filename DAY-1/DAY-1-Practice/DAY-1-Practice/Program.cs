using System;
using System.Collections.Generic;
using System.Linq;
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
            string first_name = "kshitij";
            string last_name = "wankar";
            last_name=first_name+last_name;
            Console.WriteLine(last_name);
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
        }
    }
}

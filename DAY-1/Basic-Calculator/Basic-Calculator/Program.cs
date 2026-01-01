using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers you want to do operation on");
            Console.WriteLine("enter your first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number:");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what do you want to do \n enter 1 for addition\n enter 2 for subtraction\n enter 3 for multiplication \n enter 4 for dividing");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("the addition is " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("the subtraction is " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("the multiplication is " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("the division is " + Convert.ToDouble(num1 / num2));
                    break;

            }

        }
    }
}

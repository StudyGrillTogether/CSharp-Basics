using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Practice
{
    class car //using multiple classes
    {
        public string color = "red";
    }
    class Myclass 
        //class members
    {
        public string color="red";
        public int Max_speed = 200;
        public void fullthrotle()
        {
            Console.WriteLine("this car is going on a max speed");
        }
    }
    // leaving the fileds blank to create multiple objects of same class
    class car1
    {
        public string color;
        public int Max_speed;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car Myobj = new car();
            Console.WriteLine(Myobj.color);

            Myclass Newobj=new Myclass();
            Console.WriteLine("the color of car is" + Newobj.color + "the max speed of car is:" + Newobj.Max_speed);
            Newobj.fullthrotle();

            car1 bentley=new car1();
            car1 ford=new car1();
            bentley.color = "red";
            bentley.Max_speed = 200;
            ford.color = "blue";
            ford.Max_speed = 300;
            Console.WriteLine("the color of bentley is :" + bentley.color);
            Console.WriteLine("the speed of bentley is :"+ bentley.Max_speed+
                "\nthe color of ford is"+ford.color+"\nthe speed of ford is:"+ford.Max_speed);

        }
    }
}

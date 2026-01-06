using DAY_2_Git_exercise;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Git_exercise
{
    class person
    {
        public string name;
        public int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("please pass a positive value");
                }
                else
                {
                    age=value;
                }
            }
        }
        //person has an adaress
        public adress adress;
        public static void Introduce(person p)
        {
            Console.WriteLine("my name is: " + p.name + " my age is " + p.age + " im from street:" + p.adress.street + " im form city: " + p.adress.city);
            //introduce is now static and takes person p as input
        }
    }

}
class adress
{
    public string street;
    public string city;

    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.name = "aster";
            person1.Age = 45;
            person1.adress = new adress();
            person1.adress.street = "lmar";
            person1.adress.city = "madrid";

            person person2 = new person();
            person2.name = "kshitij";
            person2.Age = 21;
            person2.adress = new adress();
            person2.adress.street = "kaula";
            person2.adress.city = "sephoy";
            
            person person3 = new person();
            person3.name = "mordret";
            person3.Age = 27;
            person3.adress = new adress();
            person3.adress.street = "raven";
            person3.adress.city = "BARCELONA";

            person.Introduce(person1);//person class introduces the object
            person.Introduce(person3);

        }
    }
}

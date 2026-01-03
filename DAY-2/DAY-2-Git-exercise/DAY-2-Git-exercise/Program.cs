using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Git_exercise
{
    class person
    {
        public string name;
        public int age;
        
    }
    class adress:person
    {
        public string street;
        public string city;
        public void Introduce()
        {
            Console.WriteLine("my name is: " + name + " my age is " + age+" im from street:"+street+" im form city: "+city);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            adress person1 = new adress();
            person1.name = "aster";
            person1.age = 45;
            person1.street = "lmar";
            person1.city = "madrid";
            adress person2 = new adress();
            person2.name = "kshitij";
            person2.age = 21;
            person2.street = "elppo";
            person2.city = "barcelona";
            adress person3 = new adress();
            person3.name = "mordret";
            person3.age = 27;
            person3.street = "svaoi";
            person3.city = "osaka";
            person1.Introduce();
            person2.Introduce();
            person3.Introduce();

        }
    }
}

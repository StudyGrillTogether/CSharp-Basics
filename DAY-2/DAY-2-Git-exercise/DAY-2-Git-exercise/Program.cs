using DAY_2_Git_exercise;
using System;
using System.Collections.Generic;
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
        //person has an adaress
        public adress adress;
        public void Introduce()
        {
            Console.WriteLine("my name is: " + name + " my age is " + age + " im from street:" + adress.street + " im form city: " + adress.city);
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
            person1.age = 45;
            person1.adress = new adress();
            person1.adress.street = "lmar";
            person1.adress.city = "madrid";
   
            person person2 = new person();
            person2.name = "kshitij";
            person2.age = 21;
            person2.adress=new adress();
            person2.adress.street = "kaula";
            person2.adress.city = "sephoy";
            
            person person3 = new person();
            person3.name = "mordret";
            person3.age = 27;
            person3.adress=new adress();
            person3.adress.street = "raven";
            person3.adress.city = "BARCELONA";
           
            person1.Introduce();
            person2.Introduce();
            person3.Introduce();

        }
    }
}

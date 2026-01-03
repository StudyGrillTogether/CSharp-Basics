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
        public void Introduce()
        {
            Console.WriteLine("my name is: " + name + " my age is " + age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1=new person();
            person1.name = "aster";
            person1.age = 45;
            person person2=new person();
            person2.name = "kshitij";
            person2.age = 21;
            person person3 = new person();
            person3.name = "mordret";
            person3.age = 27;
            person1.Introduce();
            person2.Introduce();
            person3.Introduce();    
        }
    }
}

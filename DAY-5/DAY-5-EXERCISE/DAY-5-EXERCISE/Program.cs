using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_EXERCISE
{
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("the animal makes a sound");
        }
    }
    class cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("the cat says meow meow");
        }
    }
    class dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("the dog says beo beo");
        }
    }
    class pig : Animal
    {
        public override void speak()
        {
            Console.WriteLine("pig says wee weew");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals=new List<Animal>();
            animals.Add(new Animal());
            animals.Add(new dog());
            animals.Add(new pig());
            animals.Add(new cat()); //list type aniumal stores different child objects

            foreach(var animal in animals)
            {
                animal.speak();
            }
        }
    }
}

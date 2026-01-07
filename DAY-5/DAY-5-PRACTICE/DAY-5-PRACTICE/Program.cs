using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_PRACTICE
{
    //inheritance
    class Vehicle //base class(parent)
    {
        public string brand = "ford";
        public void honk()
        {
            Console.WriteLine("tuut,tuut");
        }
    }
    class Car : Vehicle//derived class(child)
    {
        public string model = "mustang";
    }

    //ploymorphism
    class Animal
    {
        public virtual void animalsound()
        {
            Console.WriteLine("the amimal makes a sound");
        }
    }
    class pig : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("the pig says: wee wee");
        }
    }
    class dog : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("the dog says:bow wow");
        }
    }

    //method overloading that is multiple class methods with same name ut diff parameters
    class calculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int add(int x,int y,int z)
        {
            return x + y + z; 
        }

        public int add(int x, int y, int z,int p)
        {
            return x + y + z + p;
        }

        public double add(double a,double b)
        {
            return a + b;
        }

        
    }

    //using abstract classes
    abstract class Animal1
    {
        //abstrct method does not have a body
        public abstract void animalsound();
        public void slepp()
        {
            Console.WriteLine("zzz");
        }
    }
    //you cannot create objects via abstract classes

    //deived class inherited from animal1
    class pig1 : Animal1
    {
        public override void animalsound()
        {
            Console.WriteLine("the pig says: wee wee");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.honk();
            Console.WriteLine($"{mycar.model}is the model of car wit brand{mycar.brand}");
            Animal myanimal=new Animal();
            Animal mypig=new pig();
            Animal mydog=new dog();

            //example of overiding as we can see the output is the same as the
            //animal makes a sound for all three of these 
            //it happens because base class method overides the derived class method when they share the same name
            myanimal.animalsound();
            mydog.animalsound() ;
            mypig.animalsound();

            //we can overide the base class method by adding the virtual keyword to 
            //the method inside the base class and by using overide keyword for each derived class methods

            //method overloading
            calculator obj1=new calculator();
            
            Console.WriteLine($"the sum of two numbers 1 and 2 is: {obj1.add(1, 2)} and 1,2,3,4 is {obj1.add(1,2,3,4)} and 2.4 and 5.6 is {obj1.add(2.4,5.4)}");

            //using abstract classes and methods
            pig1 mypig1 = new pig1();//creating pig object
            mypig1.animalsound();//call the abstract method
            mypig1.slepp();

        }
    }
}

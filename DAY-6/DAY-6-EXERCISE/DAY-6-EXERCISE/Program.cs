using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAY_6_EXERCISE
{
    interface Ianimal
    {
        void animalsound();
    }
    class pig : Ianimal
    {
        public void animalsound()
        {
            Console.WriteLine("the pig says wee wee");
        }
    }
    class dog : Ianimal
    {
        public void animalsound()
        {
            Console.WriteLine("the dog says woof woof");
        }
    }
    
    //inherting from 1 interface or multiple interfaces
    interface Itestinterface1
    {
        void add(int num1, int num2);
    }
    interface Itestinterface2 : Itestinterface1
    {
        void sub(int num1, int num2);
    }
    public class implementationclass : Itestinterface2
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine($"{num1+num2}");
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine($"{num1 - num2}");
        }
    }//since this class inherits from itestinterface 2 it needs to iumplemtnt both abstract methods
    //otherwise it gives errors
    //hile implementing the method, we are using the public modifier, which is required. If you don’t use public,
    //it will treat the method as private, and you will get a compiler error: ‘ImplementationClass1’ does not implement interface member ‘ITestInterface1.Add(int, int)’. ‘ImplementationClass1.Add(int, int)’ cannot implement an interface member because it is not public.
    
    //creting an instance of interface
    interface Inewinterface
    {
        void add(int num1, int num2);
    }

    public class implementinweinterface:Inewinterface
    {
        public void add(int num1,int num2)
        {
            Console.WriteLine($"the sum of {num1} and {num2} is {num1 + num2} ");
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine($"the subtracion of {num1} and {num2} is{num1 - num2}");
        }
    }

    //c# multiple interfaces
    //to implement we seprate them with comma
    interface IfirstInterface
    {
        void method();
    }
    interface IsecondInterface
    {
        void myothermethod();
    }

    //implemething mutiple interfaces
    public class democlass : IfirstInterface, IsecondInterface
    {
        public void method()
        {
            Console.WriteLine("first method from first interface");

        }
        public void myothermethod()
        {
            Console.WriteLine("method from second interface");
        }
    }

    //explicit implementation of interfaces
    interface Imyinterface
    {
        void add(int num1, int num2);
    }
    interface Imyinterface2 : Imyinterface
    {
        void sub(int num1, int num2);
    }
     public class Implement : Imyinterface2
    {
        public void add(int num1,int num2)
        {
            Console.WriteLine($"the sum of {num1} and {num2} is {num1 + num2} ");
        }

        void Imyinterface2.sub(int num1, int num2)
        {
            Console.WriteLine($"the subtracion of {num1} and {num2} is{num1 - num2}");
        }
        //this is implemetation using interface name we dont need to use public acces modifier
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            pig newpig=new pig();
            newpig.animalsound();
            dog newdog = new dog();
            newdog.animalsound();
            implementationclass myobj= new implementationclass();
            myobj.sub(4, 3);

            //creating refrence of the interface
            Inewinterface newobj=new implementinweinterface();
            newobj.add(3, 4);
            //using thsi referecne we can only invoke the add method not sub method
            //this is because the add method sinature is inside the interface
            //and the sub method is not inside the interface
            implementinweinterface newobj1= new implementinweinterface();
            newobj1.add(5, 6);
            // newobj.sub(6, 5); as you can see her we cant implement this method

            //applying the concept ofmultiple interfaces
            democlass newobj2=new democlass();
            newobj2.method();
            newobj2.myothermethod();
            
        }
    }
}

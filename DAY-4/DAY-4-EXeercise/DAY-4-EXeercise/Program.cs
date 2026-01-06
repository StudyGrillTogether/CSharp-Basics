using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_EXeercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> persons=new List<string>();
            persons.Add("kshitij");
            persons.Add("jay");
            persons.Add("anvil");
            persons.Add("aster");
            bool found = false;

            Console.WriteLine("enter the name you want to search in person");
            string targetname = Console.ReadLine();
            foreach (string person in persons)
            {
                if (person == targetname)
                {
                    Console.WriteLine($"{targetname} is present in the list");
                    found = true;
                    break;
                }
                
            }
            if (!found)
            {
                Console.WriteLine($"{targetname} not found in the list");
            }
            //task2 looping through the lists
            foreach(var person in persons)
            {
                Console.WriteLine(person);
            }
            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6_EXERCISE_task
{
    interface Ilogger
    {
        void Consolelogger();
    }
    public class implemntIloger : Ilogger
    {
        public void Consolelogger()
        {
            Console.WriteLine("calling interface abstract methods inside a class ");
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

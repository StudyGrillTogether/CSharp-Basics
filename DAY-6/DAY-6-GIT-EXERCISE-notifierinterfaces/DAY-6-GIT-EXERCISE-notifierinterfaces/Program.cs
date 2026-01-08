using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6_GIT_EXERCISE_notifierinterfaces
{
    interface Inotifier
    {
        void send(string message);
    }
    public class consolenotifier : Inotifier
    {
        public void send(string message)
        {
            Console.WriteLine("console notification"+message);
        }
    }
    public class emailnotifier : Inotifier
    {
        public void send(string message)
        {
            Console.WriteLine("email notificiation"+message); 
        }
    }
    public class orderservice
    {
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Inotifier console=new consolenotifier();
            Inotifier email=new emailnotifier();
            console.send("kshitij");
            email.send("email reciverd");
        }
    }
}

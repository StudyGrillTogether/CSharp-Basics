using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_PRACTICE
{
    abstract class Animal
    {
        public abstract void sound();
    }
    class dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("dog barks");
        }
    }
    public interface ITaskRepository //interface name for task storage
    {
        void Addtask(Task task); //stores a task
        List<Task> GetTasks();//retrieve tasks
    }
    public interface ITaskService //interface name for task service
    {
        void CreateTask(string title);//buisness intent
        List<Task> GetAllTasks(); //user level operations
        void CompleteTask(int taskId); //rule based action

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new dog();
            a.sound();
            //user only knows animal makes a sound not how dog makes it 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_GIT_EXERCISE
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public void MarkCompleted()
        {
            IsCompleted = true;
        }
        public TaskItem(int id, string title)
        {
            Id = id;
            Title = title;
            IsCompleted = false;
        }

        public override string ToString()
        {
            string status = IsCompleted ? "[✓]" : "[]";
            return $"{status}{Id}.{Title}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ITaskRepository repo = new InMemoryTaskRepository();
            ITaskService service=new TaskService(repo);
            

            while (true)
            {
                Console.WriteLine("1/.create task");
                Console.WriteLine("2.list tasks");
                Console.WriteLine("3.compelete task");
                Console.WriteLine("4.delete taks");
                Console.WriteLine("5.exit");
                Console.WriteLine("enter your choice");

                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter title:");
                        service.CreateTask(Console.ReadLine());
                        break;
                    case 2:
                        foreach(var task in service.GetAllTasks())
                        {
                            Console.WriteLine(task);
                        }
                        break;
                    case 3:
                        Console.WriteLine("enter task id:");
                        service.CompleteTask(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine(("enter task id"));
                        service.DeleteTask(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }
    }
}


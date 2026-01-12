using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_GIT_EXERCISE
{
    public class TaskService:ITaskService
    {
        private ITaskRepository repository; //holds a reference to task storage
        public TaskService(ITaskRepository repository)
        {
            this.repository = repository;
        }
        public void CreateTask(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("task title cannot be empty");
                return;
            }
            TaskItem task = new TaskItem(0,title);//rpository will overwrite the id
            repository.Add(task);
        }
        public void CompleteTask(int id) //marks task as completed
        {
            TaskItem task=repository.GetByID(id);//searcehs for the task by ID
            if(task== null)
            {
                Console.WriteLine($"task not found");
                return;
            }
            if (task.IsCompleted)
            {
                Console.WriteLine("task is already completed");
                return;
            }
            task.MarkCompleted();
            repository.Update(task);
        }
        public List<TaskItem> GetAllTasks()
        {
            return repository.GetAll(); //fetches all tasks
        }

        public void DeleteTask(int id)
        {
            TaskItem task = repository.GetByID(id);
            if (task == null)
            {
                Console.WriteLine("task not found");
                return;
            }
            repository.Delete(id); //removes the task doesnt care how it happens
        }
    }
}

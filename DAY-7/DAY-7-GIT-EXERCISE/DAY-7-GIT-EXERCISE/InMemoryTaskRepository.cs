using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_GIT_EXERCISE
{

    public class InMemoryTaskRepository : ITaskRepository
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private int nextId = 1; //TRACKS next available id

        public void Add(TaskItem task)
        {
            task.Id = nextId++;
            tasks.Add(task);
        }

        public List<TaskItem> GetAll()
        {
            return tasks;
        }

        public TaskItem GetByID(int id)
        {
            foreach (var task in tasks)
            {
                if (task.Id == id)
                {
                    return task;
                }
            }
            return null; //goes through tasks one by one if it mathes =>return that task
            //if nothing matches return null
        }
        public void Update(TaskItem task)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Id == task.Id)
                {
                    tasks[i] = task;
                    return;
                }
            }
        }
        public void Delete(int id)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Id == id)
                {
                    tasks.RemoveAt(i);
                    return;
                }
            }
        }

    }
}

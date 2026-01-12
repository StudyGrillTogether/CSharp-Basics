using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_GIT_EXERCISE
{
    public interface ITaskRepository
    {
        void Add(TaskItem Task);
        List<TaskItem> GetAll();
        TaskItem GetByID(int id);
        void Update(TaskItem task);
        void Delete(int id);
    }
    //defines what storage can do and not how storage works 
    //abstraction
}

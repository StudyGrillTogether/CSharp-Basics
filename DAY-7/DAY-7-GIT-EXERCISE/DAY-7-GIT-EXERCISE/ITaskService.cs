using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_GIT_EXERCISE
{
    public interface ITaskService
    {
        void CreateTask(string title);
        void CompleteTask(int id);
        List<TaskItem> GetAllTasks();
        void DeleteTask(int id) ;
    }
}//defines or talks in terms of user actions
//hides repository details
//seperates logic from ui

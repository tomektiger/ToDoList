using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoList.DataAccess
{
    internal interface ITaskService
    {
        public void AddTask();
        public void PrintTasks();
        public void DeleteTask();
        public void MarkDoneTask();
        public void PrintTasksOrderByDescription();
        public void DeleteAllTasks();
    }
}

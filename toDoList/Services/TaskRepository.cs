using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toDoList.DataAccess;
using toDoList.Interfaces;
using toDoList.Models;

namespace toDoList.Services
{
    internal class TaskRepository : ITaskRepository
    {
        private readonly TaskContext _taskContext;

        public TaskRepository(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }

        public MyTask AddTask(MyTask task)
        {
            _taskContext.Add(task);

            _taskContext.SaveChanges();
            return task;
        }

        public void DeleteAllTasks()
        {
            _taskContext.Tasks.RemoveRange(_taskContext.Tasks);
            _taskContext.SaveChanges();
        }

        public void DeleteTask(MyTask task)
        {
            _taskContext.Tasks.Remove(task);
            _taskContext.SaveChanges();
        }

        public IEnumerable<MyTask> GetAllTasks()
        {
            return _taskContext.Tasks.ToList();
        }

        public MyTask MarkDoneTask(MyTask task)
        {
            task.IsDone = true;
            _taskContext.SaveChanges();
            return task;
        }
    }
}

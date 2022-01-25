

using toDoList.Models;

namespace toDoList.Interfaces
{
    internal interface ITaskRepository
    {
        public MyTask AddTask(MyTask task);
        public IEnumerable<MyTask> GetAllTasks();
        public void DeleteTask(MyTask task);
        public MyTask MarkDoneTask(MyTask task);
        public void DeleteAllTasks();
    }
}

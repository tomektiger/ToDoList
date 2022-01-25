using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toDoList.DataAccess;
using toDoList.Interfaces;
using toDoList.Models;
using static toDoList.UIHelper;

namespace toDoList.Services
{
    internal class TaskService : ITaskService

    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void AddTask()
        {
            string description = GetValueFromUser("Provide description for task");
            string startDate = GetValueFromUser("Provide start date");

            _taskRepository.AddTask(new MyTask(description, startDate));
        }

        public void DeleteAllTasks()
        {
            _taskRepository.DeleteAllTasks();
        }

        public void DeleteTask()
        {
            var tasks = _taskRepository.GetAllTasks().ToArray();

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i].PrintTask(i + 1);
            }

            int choiseId = GetIntegerValueFromUser("Provide task id to delete") - 1;

            if (!(choiseId >= 0 && choiseId < tasks.Length))
            {
                Console.WriteLine("Wrong ID provided");
                return;
            }

            _taskRepository.DeleteTask(tasks[choiseId]);

        }

        public void MarkDoneTask()
        {
             var tasks = _taskRepository.GetAllTasks().ToArray();

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i].PrintTask(i + 1);
            }

            int choiseId = GetIntegerValueFromUser("Provide task id to delete") - 1;

            if (!(choiseId >= 0 && choiseId < tasks.Length))
            {
                Console.WriteLine("Wrong ID provided");
                return;
            }

            _taskRepository.MarkDoneTask(tasks[choiseId]);
        }

        public void PrintTasks()
        {
            var tasks = _taskRepository.GetAllTasks().ToArray();

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i].PrintTask(i + 1);
            }
        }

        public void PrintTasksOrderByDescription()
        {
            var tasks = _taskRepository.GetAllTasks().OrderBy(task => task.Description).ToArray();

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i].PrintTask(i + 1);
            }
        }

    }
}
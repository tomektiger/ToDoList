using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using toDoList.DataAccess;
using toDoList.Interfaces;
using toDoList.Services;
using static toDoList.UIHelper;


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    services
    .AddDbContext<TaskContext>(options => options.UseSqlServer("Server=.\\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;"))
    .AddScoped<ITaskService, TaskService>()
    .AddScoped<ITaskRepository, TaskRepository>()
    )
    .Build();

PrintWelcome();


bool isProgramRun = true;

var taskService = host.Services.GetService<ITaskService>();

do
{
    PrintMenu();
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            taskService.PrintTasks();
            break;
        case 2:
            taskService.AddTask();
            break;
        case 3:
            taskService.DeleteTask();
            break;
        case 4:
            taskService.MarkDoneTask();
            break;
        case 5:
            taskService.PrintTasksOrderByDescription();
            break;
        case 6:
            taskService.DeleteAllTasks();
            break;
        case 7:
            isProgramRun = false;
            PrintEndMessage();
            break;
        default:
            PrintWrongChoiseMessage();
            break;
    }
} while (isProgramRun);



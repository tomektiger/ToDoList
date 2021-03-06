using toDoList.DataAccess;
using toDoList.Models;
using static toDoList.Helpers;
namespace toDoList;


public class TaskListAction

{ 
    public static void PrintTasksList()
    {
        PrintStars();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\t\tTASKS TO DO");
        Console.ResetColor();
        PrintStars();
        
        var context = new TaskContext();
        
        var taskList = context.Tasks;
        
        int counter = 1;
        char check = '0';
        
        foreach (var task in taskList)
        {
            if (task.Check)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                check = '\u2713';
                
            }
            else if (!task.Check)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                check = '\u2717';
                Console.ResetColor();
            }
            
            Console.WriteLine($"{counter}. {task.Task} \t[{task.Date}]\t[{check}]");
            counter++;

        }
    }
    public static void PerformTask(int choice)
    {
        var context = new TaskContext();
        var taskList = context.Tasks;

        switch (choice)
        {
            case 1:
                Console.Clear();
                PrintDashes();
                PrintTasksList();
                break;
            case 2:
                Console.Clear();
                PrintDashes();
                Console.WriteLine("What task at what time do you want to add ?");

                while (true)
                {
                    try
                    {

                        Console.Write("Task: ");
                        string task = Console.ReadLine();
                        var newTask = new Tasks();
                        newTask.Task = task;

                        Console.Write("Day and time [Wednesday 14:00]: ");
                        string time = Console.ReadLine();
                        newTask.Date = time;

                        if (!string.IsNullOrWhiteSpace(task))
                        {
                            context.Tasks.Add(newTask);
                            context.SaveChanges();
                            Console.WriteLine($"{task} Successfully added to the list :)");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You have to write something");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Something went wrong: {e.Message}");
                    }
                }

                break;
            case 3:
                Console.Clear();
                PrintTasksList();
                PrintDashes();
                Console.WriteLine("What do you want to delete ? ");
                Console.Write("Choose task by name: ");

                while (true)
                {
                    try
                    {
                        var choosedTask = Console.ReadLine();

                        if (choosedTask != "")
                        {
                            foreach (var task in taskList)
                            {
                                if (task.Task == choosedTask)
                                {
                                    context.Remove(task);
                                }
                            }

                            Console.WriteLine($"{choosedTask} successfully deleted :)");
                            context.SaveChanges();
                            break;
                        }

                        else
                        {
                            Console.WriteLine("You have to pick correct task");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Something went wrong: {e.Message}");
                    }
                }

                break;
            case 4:
                Console.Clear();
                PrintDashes();
                PrintTasksList();
                PrintDashes();
                Console.Write("Which task have you done (name) ?: ");
                string checkedTask = Console.ReadLine();

                foreach (var task in taskList)
                {
                    if (task.Task == checkedTask)
                    {
                        task.Check = true;
                    }
                }

                context.SaveChanges();
                break;
            case 5:
                Console.Clear();
                PrintDashes();

                int counter = 1;
                char check = '0';

                Console.WriteLine("Sorted list: \n");
                foreach (var task in taskList.ToList().OrderBy(w => w.Task))
                {
                    if (task.Check)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        check = '\u2713';

                    }
                    else if (!task.Check)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        check = '\u2717';
                        Console.ResetColor();
                    }

                    Console.WriteLine($"{counter}. {task.Task} \t[{task.Date}]\t[{check}]");
                    counter++;
                }

                break;
            case 6:
                
                foreach (var task in taskList)
                {
                    taskList.Remove(task);
                }
                context.SaveChanges();

                break;
            case 7:
                Console.Clear();
                Console.WriteLine("Thank you for using my app :)" +
                                  "\nI wish you well, Tomasz Kremiec :)");
                Environment.Exit(0);
                break;
        }
    }
}
using static toDoList.Beautify;
using static toDoList.TaskListAction;

namespace toDoList;

public class Menu
{ 
    public static void Choice()
    {
        Console.WriteLine("\nWhat do you want to do ?");
        Console.WriteLine("Available choices: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Decoration();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("1. Print the entire list of tasks");
        Console.WriteLine("2. Add new task");
        Console.WriteLine("3. Delete task");
        Console.WriteLine("4. Make task checked");
        Console.WriteLine("5. Sort alphabetically");
        Console.WriteLine("6. Clean list");
        Console.WriteLine("7. Quit app");
        Console.ResetColor();
        Console.Write("\nEnter your choice: ");
        Console.ResetColor();
        
        while (true)
        {
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice <= 0 || choice > 7)
                {
                    Decoration();
                    Console.WriteLine("\t \tERROR !!!");
                    Decoration();
                    Console.WriteLine("You have to choose a number between 1 and 6");
                    Console.Write("\nEnter your choice: ");
                }
                else
                {
                    performTask(choice);
                    Decoration();
                    Console.WriteLine("\n\n");
                    Console.Write("What next ?: ");
                    Choice();
                    Decoration();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
                Console.Write("\nEnter your choice: ");
            }
        }
    }
    
}

using static toDoList.Helpers;
using static toDoList.TaskListAction;

namespace toDoList;

public class Menu
{ 
    public static void PrintMenuAndMakeChoice()
    {
        Console.WriteLine("\nWhat do you want to do ?");
        Console.WriteLine("Available choices: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        PrintDashes();
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
                //THERE WE CHECK USER OPTION
                int choice = int.Parse(Console.ReadLine());
                if (choice is <= 0 or > 7)
                {
                    PrintDashes();
                    Console.WriteLine("\t \tERROR !!!");
                    PrintDashes();
                    Console.WriteLine("You have to choose a number between 1 and 7");
                    Console.Write("\nEnter your choice: ");
                }
                else
                {
                    //THERE WE ARE PERFORMING USER CHOICE
                    PerformTask(choice);
                    PrintDashes();
                    Console.WriteLine("\n\n");
                    Console.Write("What next ?: ");
                    PrintMenuAndMakeChoice();
                    PrintDashes();
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

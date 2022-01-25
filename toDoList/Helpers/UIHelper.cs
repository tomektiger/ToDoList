namespace toDoList;

public class UIHelper
{
    public static void PrintLine()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
    }

    public static void PrintWelcome()
    {
        PrintLine();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\tWELCOME TO MY TODO APP !! :)");
        Console.WriteLine("\tIT WAS MADE FOR AN INTERVIEW");
        Console.ResetColor();
        PrintLine();
    }

    public static void PrintMenu() {
        Console.WriteLine("\nWhat do you want to do ?");
        Console.WriteLine("Available choices: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        PrintLine();
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
    }
  
    public static void PrintStarLine()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("********************************************");
        Console.ResetColor();
    }
    public static void PrintEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Thank you for using my app :)" +
                          $"\nI wish you well, Tomasz Kremiec :)");
    }
    public static void PrintWrongChoiseMessage()
    {
        PrintLine();
        Console.WriteLine("You have to choose a number between 1 and 6");
    }

    public static string GetValueFromUser(string message)
    {
        string value;
        do
        {
            Console.WriteLine(message);
            value = Console.ReadLine();

            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Value can not be empty");
            }
        } while (string.IsNullOrEmpty(value));
        return value;
    }
    public static int GetIntegerValueFromUser(string message)
    {
        int value;
        bool isParsed;
        do
        {
            Console.WriteLine(message);
            var stringValue = Console.ReadLine();

            if (string.IsNullOrEmpty(stringValue))
            {
                Console.WriteLine("Value can not be empty");
            }

            isParsed = int.TryParse(stringValue, out value);
            if (isParsed)
            {
                Console.WriteLine("You have to provide number");
            }

        } while (!isParsed);
        return value;
    }
}
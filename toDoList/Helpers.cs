namespace toDoList;

public class Helpers
{
    public static void PrintDashes()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
    }

    public static void PrintWelcome()
    {
        PrintDashes();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\tWELCOME TO MY TODO APP !! :)");
        Console.WriteLine("\tIT WAS MADE FOR AN INTERVIEW");
        Console.ResetColor();
        PrintDashes();
    }
  
    public static void PrintStars()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("********************************************");
        Console.ResetColor();
    }
}
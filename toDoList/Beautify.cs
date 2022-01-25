namespace toDoList;

public class Beautify
{
    public static void Decoration()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
    }

    public static void PrintWelcome()
    {
        Decoration();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\tWELCOME TO MY TODO APP !! :)");
        Console.WriteLine("\tIT WAS MADE FOR AN INTERVIEW");
        Console.ResetColor();
        Decoration();
    }
  
    public static void Decorate()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("********************************************");
        Console.ResetColor();
    }
}
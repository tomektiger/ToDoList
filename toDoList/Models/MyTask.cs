namespace toDoList.Models;

public class MyTask
{
    public MyTask(string description, string startDate)
    {
        Description = description;
        StartDate = startDate;
    }
    public Guid Id {get; set; }
    public string? Description {get; set; } 
    public string? StartDate {get; set; }
    public bool IsDone {get; set; }

    public void PrintTask(int index)
    {
        char sign;
        if (IsDone)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            sign = '\u2713';
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            sign = '\u2717';
        }
        Console.WriteLine($"{index}. {Description} \t[{StartDate}]\t[{sign}]");
        Console.ResetColor();
    }

}


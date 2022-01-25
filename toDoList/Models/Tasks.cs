namespace toDoList.Models;

public class Tasks
{
    public Guid Id {get; set; }
    public string? Task {get; set; } 
    public string? Date {get; set; }
    public bool Check {get; set; }
    
}
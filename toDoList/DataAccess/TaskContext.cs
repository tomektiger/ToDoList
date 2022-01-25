using Microsoft.EntityFrameworkCore;
using toDoList.Models;

namespace toDoList.DataAccess;

public class TaskContext : DbContext
{
    public TaskContext() { }
    public TaskContext(DbContextOptions options) : base(options) { }
    public DbSet<Tasks> Tasks { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;database=toDoList;user=user;password=password");
    }
}
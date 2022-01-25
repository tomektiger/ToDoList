using Microsoft.EntityFrameworkCore;
using toDoList.Models;

namespace toDoList.DataAccess;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions options) : base(options) { }
    public DbSet<MyTask> Tasks { get; set; }

}
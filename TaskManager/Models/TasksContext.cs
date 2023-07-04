using Microsoft.EntityFrameworkCore;

namespace TaskManager.Models
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options)
        : base(options)
        {
        }

        public DbSet<Task> TodoItems { get; set; } = null!;
    }
}

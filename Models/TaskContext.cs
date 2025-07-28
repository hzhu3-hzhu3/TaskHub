using Microsoft.EntityFrameworkCore;

namespace TaskHub.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
        }

        public DbSet<TodoTask> Tasks { get; set; } = default!;
        
    }
}

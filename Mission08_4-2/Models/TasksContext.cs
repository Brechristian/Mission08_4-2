using Microsoft.EntityFrameworkCore;

namespace Mission08_4_2.Models
{
    public class TasksContext : DbContext 
    {
        public TasksContext(DbContextOptions<TasksContext>options) : base (options)
        {
            
        }
    }
}

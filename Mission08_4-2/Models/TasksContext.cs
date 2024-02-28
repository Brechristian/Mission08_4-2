using Microsoft.EntityFrameworkCore;

namespace Mission08_4_2.Models
{
    public class TasksContext : DbContext 
    {
        public TasksContext(DbContextOptions<TasksContext>options) : base (options) // Constructor
        {
        }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Quadrant> Quadrants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quadrant>().HasData(
                new Quadrant { QuadrantID = 1, QuadrantName = "Urgent/Important"},
                new Quadrant { QuadrantID = 2, QuadrantName = "Not Urgent/Important" },
                new Quadrant { QuadrantID = 3, QuadrantName = "Urgent/Not Important" },
                new Quadrant { QuadrantID = 4, QuadrantName = "Not Urgent/Not Important" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home" },
                new Category { CategoryID = 2, CategoryName = "School" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Church" }
                );
        }
    }
}

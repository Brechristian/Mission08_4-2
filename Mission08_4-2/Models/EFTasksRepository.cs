using Microsoft.AspNetCore.Mvc;

namespace Mission08_4_2.Models
{
    public class EFTasksRepository : ITasksRepository
    {
        private TasksContext _context;

        public EFTasksRepository(TasksContext temp) 
        {
            _context = temp;
        }

        public List<Tasks> Tasks => _context.Tasks.ToList();
        public List<Quadrant> Quadrants => _context.Quadrants.ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public void AddTask(Task task) 
        {
            _context.Add(task);
            _context.SaveChanges();
        }
    }
}

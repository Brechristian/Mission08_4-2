using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public void AddTask(Tasks task) 
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public void EditTask(Tasks updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
        }

        public void DeleteTask(Tasks deletedRecord)
        {
            _context.Tasks.Remove(deletedRecord);
            _context.SaveChanges();
        }

        public List<Tasks> GetTasksWithDetails()
        {
            return _context.Tasks
                .Include(t => t.Category)
                .Include(t => t.Quadrant)
                .ToList();
        }



    }
}

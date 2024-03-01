using Microsoft.EntityFrameworkCore;

namespace Mission08_4_2.Models
{
    public interface ITasksRepository
    {
        List<Tasks> Tasks { get; }
        public void AddTask(Tasks t);

        List<Category> Categories { get;}
        List<Quadrant> Quadrants { get; }

    }
}
//test
using Microsoft.EntityFrameworkCore;

namespace Mission08_4_2.Models
{
    public interface ITasksRepository
    {
        List<Tasks> Tasks { get; }
        public void AddTask(Tasks t);
        public void EditTask(Tasks updatedInfo);
        public void DeleteTask(Tasks deletedRecord);

        List<Category> Categories { get;}
        List<Quadrant> Quadrants { get; }

    }
}
//test
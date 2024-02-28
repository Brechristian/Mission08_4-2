using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_4_2.Models
{
	public class Tasks
	{
		[Key]
		[Required]

		public int TaskID { get; set; }
        [Required]
        public string TaskName { get; set; }

        public string? Due_Date { get; set; }

        [Required]
        [ForeignKey("CategoryID")]

        public int CategoryID { get; set; }

        public Category? Category { get; set; }

        [Required]
        [ForeignKey("QuadrantID")]

        public int QuadrantID { get; set; }
        
        public Quadrant? Quadrant { get; set; }

        [Required]
        public bool Completed { get; set; }

	



    }
}

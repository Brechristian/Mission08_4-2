using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_4_2.Models
{
	public class Tasks
	{
		[Key]
		[Required]
		public int TaskID { get; set; }
        [Required(ErrorMessage = "Please give the task a name.")]
        [StringLength(25)]
        public string? TaskName { get; set; }

        public string? DueDate { get; set; }

        [Required(ErrorMessage = "Please choose a category ID.")]
        [ForeignKey("CategoryID")]

        public int CategoryID { get; set; }

        public Category? Category { get; set; }

        [Required(ErrorMessage = "Please choose a quadrant ID.")]
        [ForeignKey("QuadrantID")]

        public int QuadrantID { get; set; }
        
        public Quadrant? Quadrant { get; set; }

        [Required(ErrorMessage = "Please indicate if the task is complete or not.")]
        public bool Completed { get; set; }

	



    }
}

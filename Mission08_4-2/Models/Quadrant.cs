using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_4_2.Models
{
	public class Quadrant
	{
        [Key]
        [Required]
        public int QuadrantID { get; set; }

        public string QuadrantName { get; set; }
    }
}
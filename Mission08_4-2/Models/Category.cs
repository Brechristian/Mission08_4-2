using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_4_2.Models
{
	public class Category
	{
		[Key]
        [Required]
        public int CategoryID { get; set; }

		public string CategoryName { get; set; }

	}
}

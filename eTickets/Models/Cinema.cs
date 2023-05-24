using System;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.Base;

namespace eTickets.Models
{
	public class Cinema : IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Display(Name ="Cinema Logo")]
		[Required(ErrorMessage = "Cinema logo is required")]
		public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string Description { get; set; }

		//Relationships
		public List<Movie>? Movies { get; set; }

		public Cinema()
		{
		}
	}
}


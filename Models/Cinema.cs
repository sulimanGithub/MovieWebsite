using MovieWebsite.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MovieWebsite.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cinema Logo Is Required")]
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Cinema Name Is Required")]
        [Display(Name = "Cinema Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cinema Description Is Required")]
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }

    }
}

using MovieWebsite.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MovieWebsite.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture URL Is Required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name Is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string  FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string  Bio { get; set; }

        public List<Movie_Actor> Movie_Actor { get; set; }


    }
}

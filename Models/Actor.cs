using System.ComponentModel.DataAnnotations;

namespace eTicketApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "bio picture required")]
        public string Bio { get; set; }
        [Display(Name = "Actors Full Name")]
        [Required(ErrorMessage = "full name picture required")]
        public string FullName { get; set; }
        [Display (Name="Profile Picture URL")]
        [Required(ErrorMessage ="prfile picture required")]
       
        public string ProfilePictureURL { get; set; }
        public List<Actor_Movies> Actor_Movies { get; set; }
    }
}

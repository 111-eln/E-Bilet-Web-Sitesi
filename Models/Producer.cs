using System.ComponentModel.DataAnnotations;

namespace eTicketApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Bio of producer")]
        public string Bio { get; set; }
        [Display(Name = "full name of producer")]
        public string FullName { get; set; }
        [Display(Name = "producer pic url of producer")]
        public string ProfilePictureURL { get; set; }
        public List<Movie> Movies { get; set; }
    }
}

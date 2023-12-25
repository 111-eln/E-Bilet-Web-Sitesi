using System.ComponentModel.DataAnnotations;

namespace eTicketApp.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name= "Logo of Cinema")]
        public string Logo { get; set; }

        [Display(Name="Name of Cinema")]
        public string Name { get; set; }
        [Display(Name = "Name of Description")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}

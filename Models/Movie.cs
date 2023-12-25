using eTicketApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name = "Desc")]
        public string Description { get; set; }
        [Display(Name = "price")]
        public double price { get; set; }
        [Display(Name = "url")]
        public string imageURL { get; set; }    
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; } // buradaki moviecategory enum olarak ayarlandı.
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        public List<Actor_Movies> Actor_Movies { get; set; }
    }
}

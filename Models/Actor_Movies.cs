namespace eTicketApp.Models
{
    public class Actor_Movies
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}

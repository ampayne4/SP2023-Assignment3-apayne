using System.ComponentModel.DataAnnotations.Schema;

namespace SP2023_Assignment3_apayne.Models
{
    public class MovieActor
    {
        public int Id { get; set; }

        [ForeignKey("Actor")]
        public int? ActorID { get; set; }
        public Actor? Actor { get; set; }

        [ForeignKey("Movie")]
        public int? MovieID { get; set; }
        public Movie? Movie { get; set; }
    }
}

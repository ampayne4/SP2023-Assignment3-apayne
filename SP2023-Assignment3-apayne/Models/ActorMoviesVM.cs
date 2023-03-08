namespace SP2023_Assignment3_apayne.Models
{
    public class ActorMoviesVM
    {
        public Actor Actor { get; set; }
        public List<MovieActor> MovieActor { get; set; }
        public List<Tweet> Tweets { get; set; }
        public double Sentiment { get; set; }
    }
}

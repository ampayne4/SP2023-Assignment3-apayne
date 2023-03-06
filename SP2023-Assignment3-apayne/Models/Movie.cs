namespace SP2023_Assignment3_apayne.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? IMDB { get; set; }
        public string? Genre { get; set; }
        public int? ReleaseYear { get; set; }
        public byte[]? Poster { get; set; }

    }
}

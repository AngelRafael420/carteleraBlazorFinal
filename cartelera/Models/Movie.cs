namespace cartelera.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string PosterUrl { get; set; } // Nueva propiedad para la URL de la carátula

        public Movie(string title, string description, int year, string director, string posterUrl)
        {
            Title = title;
            Description = description;
            Year = year;
            Director = director;
            PosterUrl = posterUrl;
        }
    }
}
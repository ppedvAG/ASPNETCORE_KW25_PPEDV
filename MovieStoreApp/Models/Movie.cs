namespace MovieStoreApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double IMDBRating { get; set; }
        public GenreType Genre { get; set; }
    }

    public enum GenreType { Action, Thriller, Comedy, Romance, Drama, Horror, Animations, ScienceFiction, Adventure, Biography, History, Docu}
}

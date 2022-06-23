using RazorPageKurs.Models;

namespace RazorPageKurs.Services
{
    public class MovieService : IMovieService
    {
        private IList<Movie> movieList;

        public MovieService()
        {
            movieList = new List<Movie>();
            movieList.Add(new Movie() { Id = 1, Title = "CODA", Description = "Talentierte Sängerin", Price = 12.99m, IMDBRating = 8.1, Genre = GenreType.Drama });
            movieList.Add(new Movie() { Id = 2, Title = "Jurassic World", Description = "Rückkehr der Turbo Pascal entwickler", Price = 19.99m, IMDBRating = 7.5, Genre = GenreType.ScienceFiction });
            movieList.Add(new Movie() { Id = 3, Title = "King Richard", Description = "Serena und Venus Williams", Price = 21.99m, IMDBRating = 8.2, Genre = GenreType.Biography });
        }

        public IList<Movie> GetAll()
        {
            return movieList;
        }

        public Movie GetById(int id)
            => movieList.Single(movie => movie.Id == id);

        public void Create(Movie movie)
            => movieList.Add(movie);
    }
}

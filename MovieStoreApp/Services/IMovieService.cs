using MovieStoreApp.Models;

namespace MovieStoreApp.Services
{
    public interface IMovieService
    {
        IList<Movie> GetAll();
    }
}

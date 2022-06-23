using RazorPageKurs.Models;

namespace RazorPageKurs.Services
{
    public interface IMovieService
    {
        IList<Movie> GetAll();

        Movie GetById(int id);

        void Create(Movie movie);
    }
}

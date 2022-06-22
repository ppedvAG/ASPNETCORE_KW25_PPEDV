using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieStoreApp.Models;
using MovieStoreApp.Services;
using System.Text;

namespace MovieStoreApp.Pages.MovieStoreEval
{
    public class IndexTestModel : PageModel
    {
        public IList<Movie> Movies { get; set; }

        public IndexTestModel(IMovieService movieService)
        {
            Movies = movieService.GetAll();
        }

        public ContentResult OnGet()
        {
            StringBuilder builder = new StringBuilder();

            foreach ( Movie movie in Movies )
            {
                builder.Append($"Id:\t\t {movie.Id}\n");
                builder.Append($"Title:\t\t {movie.Title}\n");
                builder.Append($"Description:\t {movie.Description}\n");
                builder.Append($"Price:\t\t {movie.Price}\n");
                builder.Append($"IMDB Rating:\t {movie.IMDBRating}\n");
                builder.Append($"Genre:\t\t {movie.Genre}\n");
                builder.Append("----------------------------------------------------\n");
            }

            return Content(builder.ToString());
        }
    }
}

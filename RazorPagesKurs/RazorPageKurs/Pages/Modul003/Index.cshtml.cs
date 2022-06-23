using Microsoft.AspNetCore.Mvc;
using RazorPageKurs.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Services;

namespace RazorPageKurs.Pages.Modul003
{
    public class IndexModel : PageModel
    {
        private readonly IMovieService service;

        public IndexModel(IMovieService service)
        {
            this.service = service;
        }

        public IList<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = service.GetAll();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Models;
using RazorPageKurs.Services;

namespace RazorPageKurs.Pages.Modul003
{
    public class DetailsModel : PageModel
    {
        private readonly IMovieService service;

        public DetailsModel(IMovieService service)
        {
            this.service = service;
        }

        public Movie Movie { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (!id.HasValue)
                return NotFound();

            Movie = service.GetById(id.Value);

            if (Movie == null)
                return NotFound();

            return Page(); //Gebe die Seite mit HTML und Daten zurück 
        }
    }
}

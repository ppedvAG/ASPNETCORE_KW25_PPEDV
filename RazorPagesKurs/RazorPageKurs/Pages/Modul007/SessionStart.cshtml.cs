using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Models;
using System.Text.Json;

namespace RazorPageKurs.Pages.Modul007
{
    public class SessionStartModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.SetInt32("age", 38);
            HttpContext.Session.SetString("Mitarbeiter", "Donald Duck");

            Movie movie = new Movie { Id = 123, Title = "Coda", Description = "Film einer Musikerin in einer Familie mit Hörproblem", Price = 19.99m, Genre = GenreType.Drama };

            string jsonString = JsonSerializer.Serialize(movie);
            HttpContext.Session.SetString("MovieDesMonats", jsonString);

        }
    }
}

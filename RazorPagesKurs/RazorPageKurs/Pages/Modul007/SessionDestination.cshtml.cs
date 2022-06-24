using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul007
{
    public class SessionDestinationModel : PageModel
    {
        public void OnGet()
        {
            //int? age = HttpContext.Session.GetInt32("age");
            //string mitarbeiter = HttpContext.Session.GetString("Mitarbeiter");

            //string jsonString = HttpContext.Session.GetString("MovieDesMonats");
            //Movie movie = JsonSerializer.Deserialize<Movie>(jsonString);
        }
    }
}

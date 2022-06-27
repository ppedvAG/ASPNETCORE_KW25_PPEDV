using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul007
{
    public class ViewDataSampleModel : PageModel
    {
        //public List<Movie> ... 
        //Sind daten die wir Manipulieren und auch Validieren 


        public void OnGet()
        {
            ViewData.Add("Email", "KevinW@ppedv.de");

            ViewData["Name"] = "Kevin";


        }
    }
}

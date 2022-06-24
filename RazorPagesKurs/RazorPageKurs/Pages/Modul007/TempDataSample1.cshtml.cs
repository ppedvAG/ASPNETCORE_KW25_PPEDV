using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul007
{
    public class TempDataSample1Model : PageModel
    {
        public void OnGet()
        {
            TempData["Lottozahlen"] = 1234567;
            TempData["Gewinner"] = "MaxMoritz";
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul008
{
    public class RouteAttributeSampleModel : PageModel
    {
        public IActionResult OnGet()
        {
            //In wie weit können wir Parameter (Query Strings übergeben->bei falschen Aufbau) - > return RedirectToPage("RouteAttributeDestinationSample", new { year = 2022, month = 6, day = 27, title = "company meeting", description = "schönes treffen" });

            return RedirectToPage("RouteAttributeDestinationSample", new { year = 2022, month = 6, day = 27, title = "the company meeting" });
        }
    }
}

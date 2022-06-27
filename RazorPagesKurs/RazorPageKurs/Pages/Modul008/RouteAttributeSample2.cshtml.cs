using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul008
{
    public class RouteAttributeSample2Model : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("RouteAttributeDestinationSample", "ABC",
                new { year = 2021, month = 6, day = 12, title = "herr der ringe" });
        }
    }
}

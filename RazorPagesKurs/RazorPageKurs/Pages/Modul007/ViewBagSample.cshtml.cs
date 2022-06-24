using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul007
{
    public class ViewBagSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Email"] = "KevinW@ppedv";
        }
    }
}

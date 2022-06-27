using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul008
{
    public class RouteTemplatesSampleModel : PageModel
    {
        //https://localhost:7119/Modul008/RouteTemplatesSample/2020/11/30/Fritzek
        public void OnGet(int year, int month, int day, string title)
        {
        }
    }
}

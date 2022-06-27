using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul008
{

    //RouteAttributeDestinationSample
    public class RouteAttributeDestinationSampleModel : PageModel
    {

        
        public void OnGet(int year, int month, int day, string title)
        {

        }

        //Mit Page-Hanlder
        public void OnGetABC(int year, int month, int day, string title)
        {

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Services;

namespace RazorPageKurs.Pages.Modul001
{
    public class DISample3Model : PageModel
    {

        public void OnGet()
        {
            IRequestCounter requestCounter =  this.HttpContext.RequestServices.GetRequiredService<IRequestCounter>();

            requestCounter = this.HttpContext.RequestServices.GetService<IRequestCounter>();
        }
    }
}

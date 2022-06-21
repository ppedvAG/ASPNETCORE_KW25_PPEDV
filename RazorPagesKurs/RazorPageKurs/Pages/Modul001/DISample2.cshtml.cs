using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Services;

namespace RazorPageKurs.Pages.Modul001
{
    public class DISample2Model : PageModel
    {
        private IRequestCounter requestCounter { get; set; }

        //Methoden Injection -> greifen hier auf den IOC Container zu
        
        public ContentResult OnGet([FromServices] IRequestCounter requestCounter)
        { 
            this.requestCounter = requestCounter;
            this.requestCounter.Anzahl++;

            return Content(requestCounter.Anzahl.ToString());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Services;

namespace RazorPageKurs.Pages.Modul001
{
    //DEPENDENCY INJECTION PATTERN 
    //Zugriff auf IOC mithilfe Konstruktor-Injection 
    public class DISample1Model : PageModel
    {
        private IRequestCounter requestCounter { get;set; }


        //Konstruktor Injction -> Ich kann mit Konstruktor auf IOC Container zugreifen
        //IRequestCounter counter = serviceProvider.GetRequiredService<IRequestCounter>();
        public DISample1Model(IRequestCounter counter) //GetRequiredService
        {
            requestCounter = counter;
        }

        //ContentResult -> String - Ausgabe
        public ContentResult OnGet()
        {
            requestCounter.Anzahl++;
            return Content(requestCounter.Anzahl.ToString()); //Einfache String ausgabe (sogar  Escape-Zeichen arbeiten)
        }
    }
}

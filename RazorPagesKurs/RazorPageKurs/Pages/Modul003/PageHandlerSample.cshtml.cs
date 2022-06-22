using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul003
{
    public class PageHandlerSampleModel : PageModel
    {
        public string EinstiegMethode { get; set; }

        public void OnGet()
        {
            EinstiegMethode = "OnGet";
        }

        public void OnGetDemo()
        {
            EinstiegMethode = "OnGetDemo";
        }

        public void OnGetDemoWithParam(string param)
        {
            EinstiegMethode = $"OnGetDemoWithParam mit Parameter {param}";
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul003
{
    public class PageHandlerSampleModel : PageModel
    {
        public string EinstiegMethode { get; set; }

        //https://localhost:7119/Modul003/PageHandlerSample
        public void OnGet()
        {
            EinstiegMethode = "OnGet";
        }

        //https://localhost:7119/Modul003/PageHandlerSample?handler=demo
        //https://localhost:7119/Modul003/PageHandlerSample/Demo
        public void OnGetDemo()
        {
            EinstiegMethode = "OnGetDemo";
        }

        //https://localhost:7119/Modul003/PageHandlerSample?handler=DemoWithParam&param=hello
        //https://localhost:7119/Modul003/PageHandlerSample/DemoWithParam&param=hello -> geht leider nicht, obwohl es sehr naheligend ist 
        public void OnGetDemoWithParam(string param)
        {
            EinstiegMethode = $"OnGetDemoWithParam mit Parameter {param}";
        }
    }
}

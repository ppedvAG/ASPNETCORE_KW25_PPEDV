using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul002
{
    public class ConfigurationSample1Model : PageModel
    {
        private readonly IConfiguration configuration;

        //IConfiguration wird aus dem IOC Container aufgerufen 
        public ConfigurationSample1Model(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public ContentResult OnGet()
        {
            //explizietes auslesen mithilfe von IConfiguration
            string myKeyValue = configuration["MyKey"];
            string title = configuration["Position:Title"];
            string name = configuration["Position:Name"];
            string defaultLogging = configuration["Logging:LogLevel:Default"];

            return Content($"MyKey value: {myKeyValue} \n" +
                $"Title: {title} \n" +
                $"Name: {name} \n" +
                $"Log-Level: {defaultLogging}");
        }
    }
}

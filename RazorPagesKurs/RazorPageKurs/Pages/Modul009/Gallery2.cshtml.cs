using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul009
{
    public class Gallery2Model : PageModel
    {
        public List<string> Bilder { get; set; }


        public void OnGet()
        {
            string pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images";

            string[] allFiles = Directory.GetFiles(pfad);

            if (Bilder == null)
                Bilder = new List<string>();

            Bilder.AddRange(allFiles);
        }
    }
}

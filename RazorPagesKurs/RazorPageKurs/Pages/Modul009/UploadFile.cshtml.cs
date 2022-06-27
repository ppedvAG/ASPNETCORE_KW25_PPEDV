using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul009
{
    public class UploadFileModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);

            string savePath = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

            using (FileStream fs = new FileStream(savePath, FileMode.Create))
            {
                datei.CopyTo(fs);
            }

            return RedirectToPage("UploadFile");
        }
    }
}

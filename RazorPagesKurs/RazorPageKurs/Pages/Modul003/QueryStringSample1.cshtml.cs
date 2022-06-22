using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul003
{
    public class QueryStringSample1Model : PageModel
    {
        public int Id { get; set; }


        //https://localhost:7119/Modul003/QueryStringSample1?id=123
        public void OnGet(int id)
        {
            Id = id;
        }
    }
}

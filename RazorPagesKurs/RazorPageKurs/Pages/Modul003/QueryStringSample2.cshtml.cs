using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul003
{
    public class QueryStringSample2Model : PageModel
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }


        //https://localhost:7119/Modul003/QueryStringSample2?year=1999&month=9&name=moritz

        //
        public void OnGet(string name, int year, int month)
        {
            Name = name;
            Year = year;
            Month = month;
        }
    }
}

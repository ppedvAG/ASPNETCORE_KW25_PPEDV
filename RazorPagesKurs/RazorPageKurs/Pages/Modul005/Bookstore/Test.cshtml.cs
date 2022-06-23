using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Data;
using RazorPageKurs.Models;
using System.Text;

namespace RazorPageKurs.Pages.Modul005.Bookstore
{
    public class TestModel : PageModel
    {
        private readonly BookDbContext dbContext;

        public TestModel(BookDbContext context)
        {
            dbContext = context;
        }
        public ContentResult OnGet()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Book book in dbContext.Books)
                sb.Append($"Id: {book.Id} \t Title: {book.Title} \t Beschreibung: {book.Description}");

            return Content(sb.ToString());
        }
    }
}

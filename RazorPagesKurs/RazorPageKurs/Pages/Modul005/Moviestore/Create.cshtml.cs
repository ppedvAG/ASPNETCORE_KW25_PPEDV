using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageKurs.Data;
using RazorPageKurs.Models;

namespace RazorPageKurs.Pages.Modul005.Moviestore
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageKurs.Data.MovieDbContext _context;

        public CreateModel(RazorPageKurs.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (Movie.Title == "The Crow")
            {
                //Wenn AddModelError -> ModelState.IsValid wird false 
                ModelState.AddModelError("Movie.Title", "Der Film steht auf dem Index");
            }

            //ModelState = Serverseitige Validierung (Komma Werte funktionieren) 
            if (!ModelState.IsValid || _context.Movie == null || Movie == null)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

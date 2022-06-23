using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageKurs.Data;
using RazorPageKurs.Models;

namespace RazorPageKurs.Pages.Modul005.Moviestore
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageKurs.Data.MovieDbContext _context;

        public IndexModel(RazorPageKurs.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}

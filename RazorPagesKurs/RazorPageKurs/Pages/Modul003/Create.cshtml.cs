using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Models;
using RazorPageKurs.Services;

namespace RazorPageKurs.Pages.Modul003
{
    public class CreateModel : PageModel
    {


        private readonly IMovieService service;

        public CreateModel(IMovieService service)
        {
            this.service = service;
        }



        //Property Formular befüllt Movie-Property

        [BindProperty]
        public Movie Movie { get; set; }


        public void OnGet()
        {
        }


        //Hier kommen wir nur hin:
        //Wenn:
        //<form method="post> und ein Button/Input ein type="submit" enthält
        //Movie wird automatisch von Formular befüllt -> Model-Binding (Default-Mässig erfüllt Model-Binding 95 der Fälle)
        public IActionResult OnPost() 
        {
            Movie.Id = service.GetAll().Max(m => m.Id) + 1; //Simulieren die Id Vergabe

            service.Create(Movie);

            //Wir verklinen jetzt Code-Behind auf unsere Index-Page

            return RedirectToPage("./Index");
        }
    }
}

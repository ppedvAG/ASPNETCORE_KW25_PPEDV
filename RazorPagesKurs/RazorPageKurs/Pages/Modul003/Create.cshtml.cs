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



        //Property Formular bef�llt Movie-Property

        [BindProperty]
        public Movie Movie { get; set; }


        public void OnGet()
        {
        }


        //Hier kommen wir nur hin:
        //Wenn:
        //<form method="post> und ein Button/Input ein type="submit" enth�lt
        //Movie wird automatisch von Formular bef�llt -> Model-Binding (Default-M�ssig erf�llt Model-Binding 95 der F�lle)
        public IActionResult OnPost() 
        {
            Movie.Id = service.GetAll().Max(m => m.Id) + 1; //Simulieren die Id Vergabe

            service.Create(Movie);

            //Wir verklinen jetzt Code-Behind auf unsere Index-Page

            return RedirectToPage("./Index");
        }
    }
}

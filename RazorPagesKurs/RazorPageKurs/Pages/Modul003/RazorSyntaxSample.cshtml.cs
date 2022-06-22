using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Models;

namespace RazorPageKurs.Pages.Modul003
{
    //Page-Model beinhaltet ViewModel-Pattern
    public class RazorSyntaxSampleModel : PageModel
    {
        //Public Properties können in unserer Razor-Oberfläche verwendet werden (darstellen, eingaben entgegen nehmen) 
        public string Username { get; set; }
        public Person[] Peoples { get; set; }


        //Wenn der Browser die Seite -> \Modul003\RazorSyntaxSample anfordert (Request) 

        //Im Normalen Fall wird OnGet ausgeführt. 
        public void OnGet()
        {
            //Ausgabe von Personen-Liste
            Username = "Max und Moritz";

            Peoples = new Person[] { new Person("Max", 21), new Person("Moritz", 22) };
        }
    }
}

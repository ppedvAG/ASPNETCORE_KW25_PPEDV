using RazorPageKurs.Models;

namespace RazorPageKurs.Data
{
    public static class DataSeeder
    {
        public static void SeedBookStore(BookDbContext context)
        {
            //WEnn die Tabelle Books keine Einträge beinhaltet, legen wir Testdaten an


            if (!context.Books.Any())
            {
                context.Books.Add(new Book { Title = "Der Heimweg", Description = "Ein Krimi sicherlich" });
                context.Books.Add(new Book { Title = "ES", Description = "Clown suchte nur seine schminke" });
                context.Books.Add(new Book { Title = "11 Freunde", Description = "Fussball Kulturmagazin" });
                
                
                context.SaveChanges(); //SqL wird generiert und an Datanbank gesendet
            }
        }
    }
}

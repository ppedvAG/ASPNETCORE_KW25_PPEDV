namespace RazorPageKurs.Services
{
    public class RequestCounter : IRequestCounter
    {
        public int Anzahl { get; set; }
    }

    public class RequestCounter2
    {
        public int Anzahl { get; set; }

        public void SchreibeInDatei()
        {
            using (FileStream file = new FileStream("C:\\GehtNicht.txt", FileMode.Create))
            {

            }//file -> Dispose -> FileStream verwenden IDisposable

        }
    }



}

using System.Globalization;

namespace RazorPageKurs.Models
{
    public class CultureSwitcherModel
    {
       public CultureInfo CurrentUICulture { get; set; }    

        public List<CultureInfo> SupportedCultures { get; set; }
    }
}

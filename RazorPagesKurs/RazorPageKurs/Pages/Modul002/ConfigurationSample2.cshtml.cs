using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using RazorPageKurs.Configurations;

namespace RazorPageKurs.Pages.Modul002
{
    public class ConfigurationSample2Model : PageModel
    {
        public readonly GameSettings GameConfigSettings;

        public ConfigurationSample2Model(IOptionsSnapshot<GameSettings> gameSettings)
        {
            //Wir verzeichten auf eine Ausgabe, wenn wir die Werte erhalten, können wir via Debugger das Ergebnis anschauen
            GameConfigSettings = gameSettings.Value;
        }
        public void OnGet()
        {
        }
    }
}

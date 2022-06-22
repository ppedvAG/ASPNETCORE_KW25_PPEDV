using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using MovieStoreApp.Configurations;
using System.Text;

namespace MovieStoreApp.Pages.Settings
{
    public class SettingsTestModel : PageModel
    {
        public ContentResult OnGet([FromServices] IOptionsSnapshot<MovieStoreSettings> movieStoreSettingsSnapshot)
        {
            StringBuilder builder = new();

            builder.Append($"Sample API URL: {movieStoreSettingsSnapshot.Value.OmdbapiSettings.SampleURL}\n");
            builder.Append($"Activation-Key: {movieStoreSettingsSnapshot.Value.OmdbapiSettings.ActivateKey}\n");
            builder.Append($"Parameter:\n");
            builder.Append($"Titel-QueryParam: {movieStoreSettingsSnapshot.Value.OmdbapiSettings.OmdbapiParameter.Title}\n");
            builder.Append($"Year-QueryParam: {movieStoreSettingsSnapshot.Value.OmdbapiSettings.OmdbapiParameter.Year}\n");
            builder.Append($"Plot-QueryParam: {movieStoreSettingsSnapshot.Value.OmdbapiSettings.OmdbapiParameter.Plot}\n");
            builder.Append($"ActiveKey-QueryParam: {movieStoreSettingsSnapshot.Value.OmdbapiSettings.OmdbapiParameter.Key}\n");
            return Content(builder.ToString());
        }
    }
}

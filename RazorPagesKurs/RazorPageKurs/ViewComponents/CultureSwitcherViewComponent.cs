using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RazorPageKurs.Models;

namespace RazorPageKurs.ViewComponents
{
    public class CultureSwitcherViewComponent : ViewComponent
    {

        private readonly IOptions<RequestLocalizationOptions> localizationOptions;

        //IOC Container Zugriff
        public CultureSwitcherViewComponent(IOptions<RequestLocalizationOptions> localizationOptions)
        {
            this.localizationOptions = localizationOptions;
        }

        //Invoke ist Konvention und muss in einer ViewComponent enthalten sein
        public IViewComponentResult Invoke()
        {
            IRequestCultureFeature? cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();

            CultureSwitcherModel model = new CultureSwitcherModel
            {
                SupportedCultures = localizationOptions.Value.SupportedUICultures.ToList(),
                CurrentUICulture = cultureFeature.RequestCulture.UICulture
            };

            return View(model);
        }
    }
}

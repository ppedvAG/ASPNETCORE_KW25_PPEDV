using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1Auth.Pages.Auth
{
    //[AllowAnonymous]
    [Authorize (Roles = "Admins")]
    public class AuthPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

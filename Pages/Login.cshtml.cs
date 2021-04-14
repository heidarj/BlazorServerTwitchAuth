using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorServerTwitchAuth.Pages
{
	public class LoginModel : PageModel
    {
        public async Task OnGet() =>
            await HttpContext.ChallengeAsync("oidc", new AuthenticationProperties { RedirectUri = "/" });
    }
}

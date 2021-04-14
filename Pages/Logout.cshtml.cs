using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorServerTwitchAuth.Pages
{
	public class LogoutModel : PageModel
    {
        public async Task OnGet()
        {
            //await HttpContext.SignOutAsync("oidc");
            await HttpContext.SignOutAsync("Cookies");
        }
    }
}

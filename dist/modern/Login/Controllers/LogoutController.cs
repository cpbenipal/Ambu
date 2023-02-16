using Microsoft.AspNetCore.Mvc;

namespace UBOLD_CORE.Login.Controllers
{
    public class LogoutController : Controller
    {
        public LogoutController()
        {
        }

        [ActionName("auth-logout")]
        public IActionResult RenderLogoutPage() => View("~/Login/Views/auth-logout.cshtml");
    }
}
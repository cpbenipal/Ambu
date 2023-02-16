using Microsoft.AspNetCore.Mvc;

namespace UBOLD_CORE.Login.Controllers
{
    public class LoginController : Controller
    {
        public LoginController()
        {
        }

        [ActionName("auth-login")]
        public IActionResult RenderLoginPage() => View("~/Login/Views/auth-login.cshtml");


    }
}
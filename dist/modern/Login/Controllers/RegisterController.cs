using Microsoft.AspNetCore.Mvc;

namespace UBOLD_CORE.Login.Controllers
{
    public class RegisterController : Controller
    {
        public RegisterController()
        {
        }

        [ActionName("auth-register")]
        public IActionResult RenderRegisterPage() => View("~/Login/Views/auth-register.cshtml");
    }
}
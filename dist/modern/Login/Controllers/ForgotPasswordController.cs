using Microsoft.AspNetCore.Mvc;

namespace UBOLD_CORE.Login.Controllers
{
    public class ForgotPasswordController : Controller
    {
        public ForgotPasswordController()
        {
        }

        [ActionName("auth-recoverpw")]
        public IActionResult RenderForgotPasswordPage() => View("~/Login/Views/auth-recoverpw.cshtml");
    }
}
using Microsoft.AspNetCore.Mvc;

namespace ApplicationNandu.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LandingPage()
        {
            return View();
        }
    }
}

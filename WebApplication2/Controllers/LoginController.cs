using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

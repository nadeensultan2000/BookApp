using Microsoft.AspNetCore.Mvc;

namespace BookApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

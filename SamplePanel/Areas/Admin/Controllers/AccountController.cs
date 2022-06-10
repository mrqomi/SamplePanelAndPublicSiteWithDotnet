using Microsoft.AspNetCore.Mvc;

namespace SamplePanel.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

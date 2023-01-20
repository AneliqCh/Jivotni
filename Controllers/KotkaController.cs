using Microsoft.AspNetCore.Mvc;

namespace Jivotni.Controllers
{
    public class KotkaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

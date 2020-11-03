using Microsoft.AspNetCore.Mvc;

namespace covid19_api.Controllers
{
    public class Covid19Controller : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
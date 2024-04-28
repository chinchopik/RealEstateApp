using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Controllers
{
    public abstract class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

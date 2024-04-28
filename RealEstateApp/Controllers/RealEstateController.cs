using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Controllers
{
    public class RealEstateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

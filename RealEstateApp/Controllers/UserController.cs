using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain;
using RealEstateApp.Models.User;

namespace RealEstateApp.Controllers
{
	public class UserController : Controller
	{
		private RealEstateAppContext _context;
		public UserController(RealEstateAppContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> LoginAsync([Bind(Prefix = "l")] LoginViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", new UserViewModel { LoginViewModel = model });
			}
			var user = await _context.Agents.FirstOrDefaultAsync(l => l.Login == model.Login && l.Password == model.Password);

			if (user == null)
			{
				ViewBag.Error = "Некорректные логин или пароль";
				return View("Index", new UserViewModel { LoginViewModel = model });
			}

			return RedirectToAction("Index", "EditRealEstate");
		}

	}
}

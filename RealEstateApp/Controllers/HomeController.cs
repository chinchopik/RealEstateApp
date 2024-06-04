using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain;
using RealEstateApp.Domain.Entities;
using RealEstateApp.Models;
using RealEstateApp.Models.RealEstateList;
using System.Diagnostics;

namespace RealEstateApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RealEstateAppContext _context;


        public HomeController(ILogger<HomeController> logger, RealEstateAppContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CatalogAsync(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                return View(new CatalogViewModel { RealEstates = await GetRealEstatesAsync() });
            }
            else
            {
                var realEstates = new CatalogViewModel { RealEstates = await GetRealEstatesAsync() };
                var query = realEstates.RealEstates.Where(p => p.Address.Contains(searchString)).ToList();
                return View(new CatalogViewModel { RealEstates = query });
            }
        }
        public async Task<IActionResult> CatalogItemAsync(int id)
        {
            return View(new CatalogViewModel { RealEstate = await GetRealEstateAsync(id)});
        }
        public async Task<RealEstate> GetRealEstateAsync(int id)
        {
            return await _context.RealEstates.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<IEnumerable<RealEstate>> GetRealEstatesAsync()
        {
            return await _context.RealEstates.ToListAsync();
        }

        public async Task<IActionResult> CreateRequestAsync(CatalogViewModel catalogViewModel)
        {
            /*if (!ModelState.IsValid) return Redirect($"~/home/catalogitem?id={catalogViewModel.RealEstate.Id}");*/

            if (!catalogViewModel.Request.IsValid()) return Redirect($"~/home/catalogitem?id={catalogViewModel.RealEstate.Id}");

            await _context.Requests.AddAsync(new Request
            {
                Name = catalogViewModel.Request.Name,
                Phone = catalogViewModel.Request.Phone,
                Email = catalogViewModel.Request.Email,
                IdRealEstate = catalogViewModel.RealEstate.Id,
                RequestDate = DateTime.Now,
                Status = false
            });
            await _context.SaveChangesAsync();
            return Redirect($"~/home/catalogitem?id={catalogViewModel.RealEstate.Id}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

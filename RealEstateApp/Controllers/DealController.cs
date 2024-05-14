using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Domain.Entities;
using RealEstateApp.Domain;
using RealEstateApp.Models.DealList;
using Microsoft.EntityFrameworkCore;

namespace RealEstateApp.Controllers
{
    public class DealController : Controller
    {
        private readonly RealEstateAppContext _context;
        public DealController(RealEstateAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> DealAsync()
        {
            return View(new DealViewModel { Deals = await GetDealsAsync() });
        }
        public async Task<IEnumerable<Deal>> GetDealsAsync()
        {
            return await _context.Deals.ToListAsync();
        }
    }
}

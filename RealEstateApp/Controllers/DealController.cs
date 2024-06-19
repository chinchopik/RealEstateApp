using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Domain.Entities;
using RealEstateApp.Domain;
using RealEstateApp.Models.DealList;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Models.ClientList;

namespace RealEstateApp.Controllers
{
    public class DealController : Controller
    {
        private readonly RealEstateAppContext _context;
        public DealController(RealEstateAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> DealAsync(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                return View(new DealViewModel { Deals = await GetDealsAsync() });
            }
            else
            {
                searchString = searchString.ToLower();
                var client = new DealViewModel { Deals = await GetDealsAsync() };
                var query = client.Deals.Where(p => p.IdRealEstate.ToString() == searchString || p.IdAgent.ToString() == searchString
                                                   || p.IdRealEstate.ToString() == searchString || p.Date.ToString() == searchString);
                return View(new DealViewModel { Deals = query });
            }
        }
        public async Task<IEnumerable<Deal>> GetDealsAsync()
        {
            return await _context.Deals.ToListAsync();
        }
    }
}

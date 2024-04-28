using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain;
using RealEstateApp.Domain.Entities;
using RealEstateApp.Models.RealEstateList;

namespace RealEstateApp.Controllers
{
    public class RealEstateController : BaseController
    {
        private readonly RealEstateAppContext _context;

        public RealEstateController(RealEstateAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(new RealEstateViewModel { RealEstates = await GetRealEstatesAsync() });
        }

        public async Task<IEnumerable<RealEstate>> GetRealEstatesAsync()
        {
            return await _context.RealEstates.ToListAsync();
        }
    }
}

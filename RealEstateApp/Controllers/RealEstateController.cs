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

        public async Task<RealEstate> GetRealEstateAsync(int id)
        {
            return await _context.RealEstates.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IActionResult> CreateAsync(RealEstateViewModel realEstateViewModel)
        {
            if (!ModelState.IsValid)
            {
                realEstateViewModel.RealEstates = await GetRealEstatesAsync();
                return View("Index", realEstateViewModel);
            }

            await _context.RealEstates.AddAsync(new RealEstate
            {
                Address = realEstateViewModel.Address,
                Price = realEstateViewModel.Price               
            });

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateAsync(RealEstateViewModel realEstateViewModel)
        {
            var estate = await _context.RealEstates.FirstOrDefaultAsync(i=>realEstateViewModel.Id == i.Id);
            if(estate != null)
            {
                if (realEstateViewModel.Address != null)
                {
                    estate.Address = realEstateViewModel.Address;
                    estate.Price = realEstateViewModel.Price;
                    _context.RealEstates.Update(estate);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var realEstate = await _context.RealEstates.FirstOrDefaultAsync(i => i.Id == id);
            if(realEstate != null)
            {
                _context.RealEstates.Remove(realEstate);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}

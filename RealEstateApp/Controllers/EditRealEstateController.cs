using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain;
using RealEstateApp.Domain.Entities;
using RealEstateApp.Models.RealEstateList;

namespace RealEstateApp.Controllers
{
    public class EditRealEstateController : BaseController
    {
        private readonly RealEstateAppContext _context;

        public EditRealEstateController(RealEstateAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                return View(new EditViewModel { RealEstates = await GetRealEstatesAsync() });
            }
            else
            {
                var realEstates = new EditViewModel { RealEstates = await GetRealEstatesAsync() };
                var query = realEstates.RealEstates.Where(p => p.Address.Contains(searchString)).ToList();
                return View(new EditViewModel { RealEstates = query});
            }
        }

        public async Task<IEnumerable<RealEstate>> GetRealEstatesAsync()
        {
            return await _context.RealEstates.ToListAsync();
        }

        public async Task<RealEstate> GetRealEstateAsync(int id)
        {
            return await _context.RealEstates.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IActionResult> CreateAsync(EditViewModel editViewModel)
        {
            if (!ModelState.IsValid)
            {
                editViewModel.RealEstates = await GetRealEstatesAsync();
                return View("Index", editViewModel);
            }

            await _context.RealEstates.AddAsync(new RealEstate
            {
                Address = editViewModel.RealEstate.Address,
                Price = editViewModel.RealEstate.Price,
                TotalArea = editViewModel.RealEstate.TotalArea,
                NumberOfRooms = editViewModel.RealEstate.NumberOfRooms,
                TotalFloors = editViewModel.RealEstate.TotalFloors,
                Latitude = editViewModel.RealEstate.Latitude,
                Longitude = editViewModel.RealEstate.Longitude,
                Photo = editViewModel.RealEstate.Photo
            });

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateAsync(EditViewModel editViewModel)
        {
            var estate = await _context.RealEstates.FirstOrDefaultAsync(i=> editViewModel.Id == i.Id);
            if(estate != null)
            {
                if (editViewModel.Address != null)
                {
                    estate.Address = editViewModel.Address;
                    estate.Price = editViewModel.Price;
                    estate.NumberOfRooms = editViewModel.NumberOfRooms;
                    estate.TotalArea = editViewModel.TotalArea;
                    estate.TotalFloors = editViewModel.TotalFloors;
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

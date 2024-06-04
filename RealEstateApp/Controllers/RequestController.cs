using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain;
using RealEstateApp.Domain.Entities;
using RealEstateApp.Models.RealEstateList;
using RealEstateApp.Models.RequestList;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RealEstateApp.Controllers
{
    public class RequestController : Controller
    {
        private readonly RealEstateAppContext _context;

        public RequestController(RealEstateAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> RequestAsync(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                return View(new RequestViewModel { Requests = await GetRequestsAsync() });
            }
            else
            {
                var realEstates = new RequestViewModel { Requests = await GetRequestsAsync() };
                var query = realEstates.Requests.Where(p => p.Name.Contains(searchString) || p.Phone.Contains(searchString)
                                                   || p.Email.Contains(searchString)).ToList();
                return View(new RequestViewModel { Requests = query });
            }
        }
        public async Task<IEnumerable<Request>> GetRequestsAsync()
        {
            return await _context.Requests.ToListAsync();
        }

        public async Task<Request> GetRequestAsync(int id)
        {
            return await _context.Requests.FirstOrDefaultAsync(x => x.Id == id);
        }
		public async Task<IActionResult> ChangeRequestStatusAsync(int id)
		{
            var item = _context.Requests.FirstOrDefaultAsync(x => x.Id == id).Result.Status = true;
            await _context.SaveChangesAsync();
			return RedirectToAction("Request");
		}
	}
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain;
using RealEstateApp.Domain.Entities;
using RealEstateApp.Models.ClientList;
using RealEstateApp.Models.RealEstateList;

namespace RealEstateApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly RealEstateAppContext _context;
        public ClientController(RealEstateAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ClientAsync()
        {
            return View(new ClientViewModel { Clients = await GetClientsAsync() });
        }
        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }
    }
}

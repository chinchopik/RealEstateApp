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
        public async Task<IActionResult> ClientAsync(string searchString)
        {         
			if (String.IsNullOrEmpty(searchString))
			{
				return View(new ClientViewModel { Clients = await GetClientsAsync() });
			}
			else
			{
                searchString = searchString.ToLower();
				var client = new ClientViewModel { Clients = await GetClientsAsync() };
				var query = client.Clients.Where(p => p.LastName.Contains(searchString) || p.FirstName.Contains(searchString)
                                                   || p.Patronymic.Contains(searchString) || p.Phone.Contains(searchString) || p.Email.Contains(searchString)).ToList();
				return View(new ClientViewModel { Clients = query });
			}
		}
        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }
		public async Task<Client> GetClientAsync(int id)
		{
			return await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task<IActionResult> CreateAsync(ClientViewModel clientViewModel)
        {
            if (!ModelState.IsValid)
            {
                clientViewModel.Clients = await GetClientsAsync();
                return View("Client", clientViewModel);
            }

            await _context.Clients.AddAsync(new Client
            {
                FirstName = clientViewModel.FirstName,
                LastName = clientViewModel.LastName,
                Patronymic = clientViewModel.Patronymic,
                Phone = clientViewModel.Phone,
                Email = clientViewModel.Email
            });

            await _context.SaveChangesAsync();
            return RedirectToAction("Client");
        }

        public async Task<IActionResult> UpdateAsync(ClientViewModel clientViewModel)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(i => clientViewModel.Id == i.Id);;
            if (client != null)
            {
                if (ModelState.IsValid)
                {
					client.LastName = clientViewModel.LastName;
					client.FirstName = clientViewModel.FirstName;
					client.Patronymic = clientViewModel.Patronymic;
					client.Phone = clientViewModel.Phone;
					client.Email = clientViewModel.Email;
					_context.Clients.Update(client);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Client");
        }
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(i => i.Id == id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Client");
        }
    }
}

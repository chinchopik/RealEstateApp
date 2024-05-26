using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Domain.Entities;

namespace RealEstateApp.Views.Shared.Components.RealEstate
{
    public class ClientViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(RealEstateApp.Domain.Entities.Client client)
        {
            return View(client);
        }
    }
}

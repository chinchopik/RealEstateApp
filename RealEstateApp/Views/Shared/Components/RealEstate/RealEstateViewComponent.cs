using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Domain.Entities;

namespace RealEstateApp.Views.Shared.Components.RealEstate
{
    public class RealEstateViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(RealEstateApp.Domain.Entities.RealEstate realEstate)
        {
            return View(realEstate); 
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Views.Shared.Components.RealEstateListItem
{
    public class RealEstateListItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(RealEstateApp.Domain.Entities.RealEstate realEstate)
        {
            return View(realEstate);
        }
    }
}


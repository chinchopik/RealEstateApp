using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Views.Shared.Components.Deal
{
    public class DealViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(RealEstateApp.Domain.Entities.Deal deal)
        {
            return View(deal);
        }
    }
}

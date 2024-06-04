using Microsoft.AspNetCore.Mvc;

namespace RealEstateApp.Views.Shared.Components.Request
{
    public class RequestViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(RealEstateApp.Domain.Entities.Request request)
        {
            return View(request);
        }
    }
}

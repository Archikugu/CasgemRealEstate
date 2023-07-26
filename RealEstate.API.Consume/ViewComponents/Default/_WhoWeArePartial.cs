using Microsoft.AspNetCore.Mvc;

namespace RealEstate.API.Consume.ViewComponents.Default
{
    public class _WhoWeArePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

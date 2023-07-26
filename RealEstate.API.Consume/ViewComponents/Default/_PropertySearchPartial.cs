using Microsoft.AspNetCore.Mvc;

namespace RealEstate.API.Consume.ViewComponents.Default
{
    public class _PropertySearchPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

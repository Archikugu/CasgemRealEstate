using Microsoft.AspNetCore.Mvc;

namespace RealEstate.API.Consume.ViewComponents.Default
{
    public class _CompanyPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

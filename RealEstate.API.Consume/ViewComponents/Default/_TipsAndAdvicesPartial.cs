using Microsoft.AspNetCore.Mvc;

namespace RealEstate.API.Consume.ViewComponents.Default
{
    public class _TipsAndAdvicesPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

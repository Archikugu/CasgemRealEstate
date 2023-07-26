using Microsoft.AspNetCore.Mvc;

namespace RealEstate.API.Consume.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

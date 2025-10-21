using Microsoft.AspNetCore.Mvc;

namespace Asset_Management.Controllers
{
    public class AssetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

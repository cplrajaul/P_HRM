using Microsoft.AspNetCore.Mvc;

namespace P_HRM.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

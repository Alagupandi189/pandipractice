using Microsoft.AspNetCore.Mvc;

namespace JSDevwebstore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

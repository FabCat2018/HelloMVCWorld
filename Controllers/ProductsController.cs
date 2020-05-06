using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    [Route("/products")]
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Product overview");
        }

        public IActionResult List()
        {
            return Content("Product list");
        }

        [Route("{id}")]
        [Route("/product/{id}")]
        public IActionResult Details(int id)
        {
            return Content("Product details for #" + id);
        }
    }
}
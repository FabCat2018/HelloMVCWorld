using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return Content("Hello, MVC World!");
		}
	}
}
using HelloMVCWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HelloMVCWorld.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			Movie movie = new Movie() {
				Title = "The Godfather",
				ReleaseDate = new DateTime(1972, 3, 24)
			};

			return View(movie);
		}
	}
}
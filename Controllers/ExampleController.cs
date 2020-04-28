using HelloMVCWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class ExampleController : Controller
    {
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            return Content("Movie updated");
        }

        // Content() returns the specified string as plain text to the client
        // View() returns a View to the client
        // PartialView() returns a partial View to the client
        // File() returns the content of a specified file to the client
        // Json() returns a JSON response to the client
        // Redirect() and RedirectParameter() returns  a redirected response to the browser (temporary or permanent), redirecting the user to
        // another URL
        // StatusCode() returns a custom status code to the client


    }
}
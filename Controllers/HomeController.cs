using Microsoft.AspNetCore.Mvc;
using RouteDemo.Models;
using System.Diagnostics;

namespace RouteDemo.Controllers
{


    [Route("Home")]
    public class HomeController : Controller
    {  
        [Route("")]      
        [Route("Index")]
        [Route("default")]
        public IActionResult Index()
        {
            return View();
        }

       [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
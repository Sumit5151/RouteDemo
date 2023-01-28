using Microsoft.AspNetCore.Mvc;

namespace RouteDemo.Controllers
{
    public class StudentController : Controller
    {

        
        [Route("Detail%sssss")]
        public IActionResult Details()
        {
            return View();
        }
    }
}

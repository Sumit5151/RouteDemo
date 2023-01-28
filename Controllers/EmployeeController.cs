using Microsoft.AspNetCore.Mvc;
using RouteDemo.DAL;
using Microsoft.EntityFrameworkCore;
namespace RouteDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly BrightDb4Context db;
        public EmployeeController(BrightDb4Context _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        public IActionResult List()
        {

            var employees =      db.Employees
                                .Include(x=>x.Department)
                                .Include(x=>x.Gender)
                                .Include(x=>x.Addresses)
                                .ToList();
            return View(employees);
        }
    }
}

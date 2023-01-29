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


        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.Genders = db.Genders.ToList();
            ViewBag.Departments = db.Departments.ToList();

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            return View(employeeViewModel);

        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeViewModel)
        {

            db.Employees.Add(employeeViewModel.employee);
            db.SaveChanges();


            employeeViewModel.address.EmployeeId = employeeViewModel.employee.Id;

            var addressMaxId = db.Addresses.Max(x => x.Id);
            employeeViewModel.address.Id = addressMaxId + 1;
            employeeViewModel.address.IsPreferred = false;

            db.Addresses.Add(employeeViewModel.address);
            db.SaveChanges();


            return RedirectToAction("List");

        }



        [HttpGet]
        public IActionResult Update(int Id)
        {
            return View();

        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            return View();

        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            return View();

        }
        
    }
}

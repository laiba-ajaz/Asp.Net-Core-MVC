using Microsoft.AspNetCore.Mvc;
using StudentEnrollementForm_CRUD.Data;
using StudentEnrollementForm_CRUD.Models;

namespace StudentEnrollementForm_CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDBContext _context;

        public StudentController(AppDBContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Content("Data saved successfully!");
        }
    }
}
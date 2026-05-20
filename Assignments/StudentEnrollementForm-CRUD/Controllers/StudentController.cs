using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
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
            return RedirectToAction("ViewStudents");
        }

        public IActionResult ViewStudents()
        {
            var students = _context.Students.ToList();
            return View("ViewStudents", students);
        }



        [HttpPost]
          public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("ViewStudents");
        }

        [HttpPost]
         public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id); 
            _context.Students.Remove(student!); 
            _context.SaveChanges(); 
            return RedirectToAction("ViewStudents");
        }

    }
}
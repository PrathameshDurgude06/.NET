using Microsoft.AspNetCore.Mvc;
using StudentManagement.Service;
using BOL;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IStudentService _studentService;

        public ProductController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult GetAllStudents()
        {
            List<Student> students = _studentService.GetAll();
            ViewData["catalog"] = students;
            return View();
        }
    }
}

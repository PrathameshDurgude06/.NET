using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;
using StudentManagementSystem.Sevices;
namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        /*private readonly IStudentService _studenService;

        public StudentController(IStudentService studenService)
        {
            _studenService = studenService;
        }*/

        private readonly ConnectionContext _connectionContext;

        public StudentController(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult AddStudent(int studid,string studname,string studemail,string studmob,string studaddr,string addate,double fees,string status)
        {
            DateTime d = DateTime.Parse(addate);
            //int stubent_Id, string stubent_Name, string stubent_Email, string mobile_Number, string student_Address, DateTime admission_date, double fees, string status)
            Student stud = new Student(studid, studname, studemail, studmob, studaddr,d, fees, status);
            _connectionContext.Add(stud);
            _connectionContext.SaveChanges();
            return View();
        }
    }
}

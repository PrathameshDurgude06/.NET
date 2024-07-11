using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;

namespace StudentManagementSystem.Sevices
{
    public class StudentService : IStudentService
    {
        private readonly IDbmanager _dbmanager;


        public StudentService(IDbmanager dbmanager)
        {
            _dbmanager = dbmanager;
        }
        public StudentService() { }

        public void Insert(Student stud)
        {
            _dbmanager.Insert(stud);
        }
    }
}

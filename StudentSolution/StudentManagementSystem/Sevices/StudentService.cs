using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;

namespace StudentManagementSystem.Sevices
{
    public class StudentService : IStudentService
    {
        private readonly Dbmanager dbmanager;

        public StudentService(Dbmanager dbmanager)
        {
            this.dbmanager = dbmanager;
        }
        public StudentService() { }

        public void Insert(Student stud)
        {
            dbmanager.Insert(stud);
        }
    }
}

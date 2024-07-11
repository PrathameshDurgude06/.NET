using BOL;
using DAL;

namespace StudentManagement.Service
{
    public class StudentServiceImpl : IStudentService
    {
        private readonly IStudentRepoMang _studentRepoMang;

        public StudentServiceImpl(IStudentRepoMang studentRepoMang)
        {
            _studentRepoMang = studentRepoMang;
        }
        public List<Student> GetAll()
        {
            return _studentRepoMang.Getall();
        }
    }
}

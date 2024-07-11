
using BOL;
using StudentManagement.Repository;

namespace DAL
{
    public class StudentRepoMang : IStudentRepoMang
    {

        public List<Student> Getall()
        {
            using (var context = new CollectionContext())
            {
                var stds=from stud in context.students select stud;
                return stds.ToList<Student>();
            }
        }
    }
}

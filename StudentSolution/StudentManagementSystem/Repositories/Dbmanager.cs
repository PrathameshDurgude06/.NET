using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public class Dbmanager : IDbmanager
    {
        private readonly ConnectionContext _connectionContext;

        public Dbmanager(ConnectionContext connection)
        {
            _connectionContext = connection;
        }
        public void Insert(Student student)
        {
           _connectionContext.Studentmang.Add(student);
           _connectionContext.SaveChanges();
        }
    }
}

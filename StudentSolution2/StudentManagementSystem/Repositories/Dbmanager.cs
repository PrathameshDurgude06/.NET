using Microsoft.AspNetCore.Connections;
using StudentManagementSystem.Models;
using System.Runtime.CompilerServices;

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

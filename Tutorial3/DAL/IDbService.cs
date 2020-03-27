using System.Collections.Generic;
using Tutorial3.Models;

namespace Tutorial3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
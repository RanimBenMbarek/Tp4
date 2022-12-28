using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public interface IRepositoryStudent : IRepository<Student>
    {
        public IEnumerable<string?> GetDistinctCourses();
    }
}

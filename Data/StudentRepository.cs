using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class StudentRepository : Repository<Student>,IRepositoryStudent
    {
        private readonly UniversityContext universityContext;
        public StudentRepository(UniversityContext context)
        {
            this.universityContext = context;

        }

        public IEnumerable<string?> GetDistinctCourses()
        {

            return universityContext.Student.Select(s => s.course).Distinct().ToList();
        }
    }
}

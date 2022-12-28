using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Diagnostics;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            
            UniversityContext context = UniversityContext.Instantiate_UniversityContext();
            StudentRepository repo = new StudentRepository(context);
            return View(repo.GetDistinctCourses());
        }
        [Route("Home/Course/{course}")]
        public ActionResult Course(String course=null)
        {
            UniversityContext context = UniversityContext.Instantiate_UniversityContext();
            StudentRepository repo = new StudentRepository(context);
            Debug.WriteLine("hello i m here " + course);
            IEnumerable<Student> liste = repo.GetAll();
            List<Student> l=new List<Student>();
            foreach(Student student in liste)
            {
                if (student.course == course)
                {
                    l.Add(student);
                }
                   
            }

            return View(l);
        }
        
    }
}
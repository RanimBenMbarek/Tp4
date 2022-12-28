using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class UniversityContext : DbContext
    {

        public DbSet<Student> Student { get; set; }
        private static UniversityContext context = null;
        private UniversityContext(DbContextOptions o) : base(o) { }
        public static UniversityContext Instantiate_UniversityContext()
        {

            Debug.WriteLine("I m here !! ");
            if (context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\mbare\\OneDrive\\Bureau\\framework\\2022 GL3 .NET Framework TP4 - SQLite database.db");
                context = new UniversityContext(optionsBuilder.Options);
                return context;
            }
            return context;


        }

    }
}

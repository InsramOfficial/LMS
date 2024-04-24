using Microsoft.EntityFrameworkCore;
using ILMS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ILMS.Models
{
	public class DatabaseContext :IdentityDbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{

		}
		public DbSet<Country> countries { get; set; }
		public DbSet<Faculty> faculies { get; set; }
		public DbSet<Campus> campuses { get; set; }
		public DbSet<University> universities { get; set; }
		public DbSet<Departemement> departements { get; set; }
		public DbSet<Designation> designations { get; set; }
		public DbSet<Class> classes { get; set; }
		public DbSet<Religion> religions { get; set; }
		public DbSet<Course> courses { get; set; }
		public DbSet<Subject> subjects { get; set; }
		public DbSet<Exam> exams { get; set; }
		public DbSet<Session> sessions { get; set; }
		public DbSet<Result> results { get; set; }
		public DbSet<Attendence> attendences { get; set; }
		public DbSet<Scheme_of_Study> schemes { get; set; }
		public DbSet<View_1_Scheme> view { get; set; }
		public DbSet<Employee> employees { get; set; }
		public DbSet<Student> students { get; set; }
		public DbSet<pro> program { get; set; }
		public DbSet<City> cities { get; set; }
		

	}

}

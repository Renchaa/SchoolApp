using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rp23052NetMD4.Models;

namespace rp23052NetMD4.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Submission> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Esošā loma datu sagatavošana
            var admin = new IdentityRole("admin") { NormalizedName = "ADMIN" };
            var client = new IdentityRole("client") { NormalizedName = "CLIENT" };

            builder.Entity<IdentityRole>().HasData(admin, client);

            // Jauno tabulu attiecību konfigurācija
            builder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);

            builder.Entity<Assignment>()
                .HasOne(a => a.Course)
                .WithMany(c => c.Assignments)
                .HasForeignKey(a => a.CourseId);

            builder.Entity<Submission>()
                .HasOne(s => s.Assignment)
                .WithMany(a => a.Submissions)
                .HasForeignKey(s => s.AssignmentId);

            builder.Entity<Submission>()
                .HasOne(s => s.Student)
                .WithMany(st => st.Submissions)
                .HasForeignKey(s => s.StudentId);

            // Konfigurācija automātiskai ID ģenerēšanai
            builder.Entity<Student>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Teacher>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Course>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Assignment>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Submission>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();

            // Sākotnējo datu ievietošana (Seed Data)
            builder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Name = "John", Surname = "Doe", Gender = "Male", ContractDate = DateTime.Now.AddYears(-5) },
                new Teacher { Id = 2, Name = "Jane", Surname = "Smith", Gender = "Female", ContractDate = DateTime.Now.AddYears(-3) }
            );

            builder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Mathematics", TeacherId = 1 },
                new Course { Id = 2, Name = "Physics", TeacherId = 2 }
            );

            builder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Alice", Surname = "Johnson", Gender = "Female", StudentIdNumber = "S12345" },
                new Student { Id = 2, Name = "Bob", Surname = "Brown", Gender = "Male", StudentIdNumber = "S67890" }
            );

            builder.Entity<Assignment>().HasData(
                new Assignment { Id = 1, Deadline = DateTime.Now.AddMonths(1), CourseId = 1, Description = "Math Homework" },
                new Assignment { Id = 2, Deadline = DateTime.Now.AddMonths(1), CourseId = 2, Description = "Physics Lab Report" }
            );

            builder.Entity<Submission>().HasData(
                new Submission { Id = 1, AssignmentId = 1, StudentId = 1, SubmissionTime = DateTime.Now, Score = 85.0 },
                new Submission { Id = 2, AssignmentId = 2, StudentId = 2, SubmissionTime = DateTime.Now, Score = 90.0 }
            );
        }


    }
}

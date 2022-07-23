using Microsoft.EntityFrameworkCore;
using Employees.Models;
namespace EmployeeManagement.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //DataSeed

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 1, DepartmentName = "IT" },
                 new Department { DepartmentID = 2, DepartmentName = "HR" },
                  new Department { DepartmentID = 3, DepartmentName = "ADMIN" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Fredrick",
                    LastName = "Ndolo",
                    Email = "fredrickndolo2@gmail.com",
                    DateOfBirth = new DateTime(1993, 03, 20),
                    Gender = Gender.Male,
                    DepartmentID = 1,
                    PhotoPath = "images/003.png"
                },
                  new Employee
                  {
                      EmployeeID = 2,
                      FirstName = "Liza",
                      LastName = "Onyango",
                      Email = "lizasharon95@gmail.com",
                      DateOfBirth = new DateTime(1996, 08, 31),
                      Gender = Gender.Female,
                      DepartmentID = 2,
                      PhotoPath = "images/012.png"
                  },
                  new Employee
                  {
                      EmployeeID = 3,
                      FirstName = "Phabian",
                      LastName = "Favor",
                      Email = "phabyfavor@gmail.com",
                      DateOfBirth = new DateTime(2020, 11, 22),
                      Gender = Gender.Male,
                      DepartmentID = 3,
                      PhotoPath = "images/013.png"
                  }
                );
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}

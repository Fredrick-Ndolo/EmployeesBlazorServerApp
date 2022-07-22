using Employees.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase:ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        public void LoadEmployees()
        {

            Employees = new List<Employee>()
            {
                new Employee{
                    EmployeeID=1,
                    FirstName = "Fredrick",
                    LastName = "Ndolo",
                    Email = "fredrickndolo2@gmail.com",
                    DateOfBirth = new DateTime(1993,03,20),
                    Gender = Gender.Male,
                    DepartmentID = 1,
                    PhotoPath = "images/003.png"
                },
                  new Employee{
                    EmployeeID=2,
                    FirstName = "Liza",
                    LastName = "Onyango",
                    Email = "lizasharon95@gmail.com",
                    DateOfBirth = new DateTime(1996,08,31),
                    Gender = Gender.Female,
                    DepartmentID = 2,
                    PhotoPath = "images/012.png"
                },
                  new Employee{
                    EmployeeID=3,
                    FirstName = "Phabian",
                    LastName = "Favor",
                    Email = "phabyfavor@gmail.com",
                    DateOfBirth = new DateTime(2020,11,22),
                    Gender = Gender.Male,
                    DepartmentID = 3,
                    PhotoPath = "images/013.png"
                }
            };
        }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();

            return base.OnInitializedAsync();
        }
    }
}

using EmployeeManagement.Api.Data;
using Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await context.Employees.AddAsync(employee);

            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            var employee = await context.Employees.FindAsync(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                await context.SaveChangesAsync();

                return employee;
            }
            return null;
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await context.Employees.Where(i => i.Email == email)
                .Include(d=>d.Department)
                .SingleOrDefaultAsync();

        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var result = await context.Employees
                .Include(d => d.Department)
                .FirstOrDefaultAsync(e => e.EmployeeID == id);
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await context.Employees.ToListAsync();
            return employees;
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> employees = context.Employees.Include(d=>d.Department);

            if (!string.IsNullOrEmpty(name))
            {
                employees = employees.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name));
            }

            if (gender != null)
            {
                employees = employees.Where(e => e.Gender ==gender);
            }

            return await employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var employeeToUpdate = await context.Employees.Where(i => i.EmployeeID == employee.EmployeeID).SingleOrDefaultAsync();
            if (employeeToUpdate != null)
            {
                employeeToUpdate.Email = employee.Email;
                employeeToUpdate.DateOfBirth = employee.DateOfBirth;
                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.LastName = employee.LastName;
                employeeToUpdate.PhotoPath = employee.PhotoPath;
                employeeToUpdate.DepartmentID = employee.DepartmentID;
                employeeToUpdate.Gender = employee.Gender;

                await context.SaveChangesAsync();

                return employeeToUpdate;
            }
            return null;
        }
    }
}

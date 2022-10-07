using EmployeeManagement.Api.Data;
using Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public   async Task<Department> GetDepartment(int departmentID)
        {
            var department = await context.Departments.FindAsync(departmentID);

            if (department != null)
            {
                return department;
            }

            return null;
        }

        public async Task<List<Department>> GetDepartments()
        {
            var departments = await context.Departments.ToListAsync();

            if (departments.Count > 0)
            {
                return departments;
            }

            return null;
        }
    }
}

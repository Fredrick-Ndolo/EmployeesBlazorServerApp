using EmployeeManagement.Api.Data;
using Employees.Models;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public  Department GetDepartment(int departmentID)
        {
            var department = context.Departments.Find(departmentID);

            if (department != null)
            {
                return department;
            }

            return null;
        }

        public IEnumerable<Department> GetDepartments()
        {
            var departments = context.Departments.ToList();

            if (departments.Count > 0)
            {
                return departments;
            }

            return null;
        }
    }
}

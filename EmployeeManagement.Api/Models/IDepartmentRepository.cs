using Employees.Models;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentID);
    }
}

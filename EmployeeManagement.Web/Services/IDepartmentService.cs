using Employees.Models;

namespace EmployeeManagement.Web.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartmentByID(int id);
    }
}

using Employees.Models;
using System.Text.Json;

namespace EmployeeManagement.Web.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly HttpClient httpClient;
        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await httpClient.GetFromJsonAsync<List<Department>>($"/api/departments");
        }

        public async Task<Department> GetDepartmentByID(int id)
        {
            return await httpClient.GetFromJsonAsync<Department>($"/api/departments/{id}");
        }
    }
}

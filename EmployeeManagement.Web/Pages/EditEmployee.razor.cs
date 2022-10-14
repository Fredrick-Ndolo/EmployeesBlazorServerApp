
using EmployeeManagement.Web.Services;
using Employees.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public partial class EditEmployee
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public Employee Employee { get; set; } = new();

        public List<Department> Departments { get; set; } = new List<Department>();

        [Parameter]
        public string Id { get; set; }


        protected override async Task OnInitializedAsync()
        {

            Employee =await  EmployeeService.GetEmployeeById(int.Parse(Id));
            Departments = await DepartmentService.GetDepartments();
            await base.OnInitializedAsync();
        }

        protected void HandleValidSubmit()
        {

        }
    }
}

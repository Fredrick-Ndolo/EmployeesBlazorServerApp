using EmployeeManagement.Web.Services;
using Employees.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public partial class EmployeeDetailsPage
    {

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee? Employee { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployeeById(int.Parse(Id));
            await base.OnInitializedAsync();
        }

        protected void Mouse_Move(MouseEventArgs e)
        {

        }
    }
}

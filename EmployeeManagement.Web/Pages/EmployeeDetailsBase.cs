
using EmployeeManagement.Web.Services;
using Employees.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase:ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployeeById(int.Parse(Id));
        }

        protected void Mouse_Move(MouseEventArgs e)
        {

        }

    }
}

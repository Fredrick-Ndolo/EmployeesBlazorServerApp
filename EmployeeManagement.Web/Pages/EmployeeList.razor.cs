using EmployeeManagement.Web.Services;
using Employees.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public partial class EmployeeList
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        public bool ShowFooter { get; set; } = true;

        public int SelectedEmployeeCount { get; set; } = 0;


        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeeCount++;
            }
            else
            {
                SelectedEmployeeCount--;
            }
        }
    }
}

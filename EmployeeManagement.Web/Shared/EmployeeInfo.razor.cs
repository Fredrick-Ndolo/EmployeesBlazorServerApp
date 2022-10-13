using Employees.Models;

using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Shared
{
    public partial class EmployeeInfo
    {
        [Parameter]
        public Employee Employee { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }

        [Parameter]
        public EventCallback<bool> OnSelectionChanged { get; set; }

        protected async Task SelectionChanged(ChangeEventArgs args)
        {
            await OnSelectionChanged.InvokeAsync((bool)args.Value);
        }
        protected ConfirmDialogBox DeleteConfirmation { get; set; }
        protected async Task Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task Confirm_Delete(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {

            }
        }

    }
}

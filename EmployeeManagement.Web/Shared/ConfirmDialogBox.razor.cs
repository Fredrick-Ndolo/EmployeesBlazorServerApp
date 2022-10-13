using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Shared
{
    public partial class ConfirmDialogBox
    {
        public bool ShowDialog { get; set; }

        public void Show()
        {
            ShowDialog=true;
            StateHasChanged();
        }

        [Parameter]
        public EventCallback<bool> ShowDialogChanged { get; set; }

        protected async void ConfirmAction(bool value)
        {
            ShowDialog = false; 
            await ShowDialogChanged.InvokeAsync(value);
        }
    }
}

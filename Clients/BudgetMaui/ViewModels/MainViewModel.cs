namespace BudgetMaui.ViewModels
{
    public partial class MainViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
        [RelayCommand]
        private Task AddEventAsync() => NavigationService.PushModalAsync("newevent");
    }
}

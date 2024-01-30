namespace BudgetMaui.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            var viewModel = AppService.GetService<SettingsViewModel>();
            viewModel.Title = "Settings";
            BindingContext = viewModel;
        }
    }
}

namespace BudgetMaui.Views
{
    public partial class SettingsPage : TabbedPage
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

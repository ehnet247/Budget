namespace BudgetMaui.Views
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            var viewModel = AppService.GetService<SearchViewModel>();
            viewModel.Title = "Search";
            BindingContext = viewModel;
        }
    }
}

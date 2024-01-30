namespace BudgetMaui
{
    public partial class App : Application
    {
        private static readonly Dictionary<string, Type> _routes = new()
        {
            ["newevent"] = typeof(NewEventPage)
        };

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            UserAppTheme = PlatformAppTheme;
        }

        public static IDictionary<string, Type> Routes => _routes;

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "BudgetMaui";
            return window;
        }
    }
}

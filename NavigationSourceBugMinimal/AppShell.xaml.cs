namespace NavigationSourceBugMinimal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("MainPage/DetailPage1", typeof(DetailPage1));
            Routing.RegisterRoute("MainPage/DetailPage2", typeof(DetailPage2));

            this.Navigating += AppShell_Navigating;
        }

        private async void AppShell_Navigating(object? sender, ShellNavigatingEventArgs e)
        {
            // Check if the navigation is coming from the DetailPage2
            if (e.Source == ShellNavigationSource.Pop && e.Current.Location.OriginalString.Contains("DetailPage2", StringComparison.Ordinal))
            {
                // Cancel the current navigation
                e.Cancel();

                // Redirect to MainPage
                await Shell.Current.GoToAsync("//MainPage", animate: true);
            }
        }
    }
}

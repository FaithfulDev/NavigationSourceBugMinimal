namespace NavigationSourceBugMinimal;

public partial class DetailPage1 : ContentPage
{
    public DetailPage1()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("DetailPage2");
    }
}
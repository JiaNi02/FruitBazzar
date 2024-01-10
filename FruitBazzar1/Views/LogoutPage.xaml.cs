namespace FruitBazzar1.Views;

public partial class LogoutPage : ContentPage
{
	public LogoutPage()
	{
		InitializeComponent();
	}
    async void OnLogoutClicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("//LoginPage", animate: true);
    }

    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage", animate: true);
    }
}
namespace FruitBazzar1.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}
    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.
   TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage), animate: true);
    }
}
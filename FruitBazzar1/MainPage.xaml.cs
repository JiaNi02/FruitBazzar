using FruitBazzar1.Views;

namespace FruitBazzar1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.
	TappedEventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}


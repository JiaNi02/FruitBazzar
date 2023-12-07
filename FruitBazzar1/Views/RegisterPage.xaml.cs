namespace FruitBazzar1.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
       
    }
    async void TapGestureRecognizer_Tapped(object sender,EventArgs e)
    {
        //await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        await Shell.Current.GoToAsync(nameof(LoginPage), animate: true);
    }
}
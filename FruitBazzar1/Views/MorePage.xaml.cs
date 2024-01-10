namespace FruitBazzar1.Views;

public partial class MorePage : ContentPage
{
	public MorePage()
	{
		InitializeComponent();
	}
     async void Returnback(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage", animate: true);
    }
}
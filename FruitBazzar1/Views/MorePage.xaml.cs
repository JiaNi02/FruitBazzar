namespace FruitBazzar1.Views;

public partial class MorePage : ContentPage
{
	public MorePage()
	{
		InitializeComponent();
	}
    private async void Returnback(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
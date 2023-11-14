namespace FruitBazzar1.Views;

public partial class CartPage : ContentPage
{
	public CartPage()
	{
        InitializeComponent();
	}

    private async void OnPaymentButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Purchase());
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Details());
    }

}


using FruitBazzar1.ViewModel;
namespace FruitBazzar1.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
    }
}
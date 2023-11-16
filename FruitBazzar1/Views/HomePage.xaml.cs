using FruitBazzar1.ViewModel;
namespace FruitBazzar1.Views;


public partial class HomePage : ContentPage
{
	private readonly HomeViewModel _homeViewModel;

    public HomePage()
    {
    }

    public HomePage(HomeViewModel homeViewModel)
	{
		InitializeComponent();
        _homeViewModel= homeViewModel;
		BindingContext = _homeViewModel;
    }
}
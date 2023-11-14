namespace FruitBazzar1.Views;

public partial class ProductPage : ContentPage
{
	private readonly ProductViewModel _productViewModel;
	public ProductPage(ProductViewModel productViewModel)
	{
		InitializeComponent();
		_productViewModel = productViewModel;
		BindingContext = _productViewModel;
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
		if(_productViewModel.FromSearch)
		{
			await Task.Delay(100);
			searchBar.Focus();
		}
    }
    void searchBar_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
	{
		if(!string.IsNullOrWhiteSpace(e.OldTextValue)
			&& string.IsNullOrWhiteSpace(e.NewTextValue))
		{
			_productViewModel.SearchProductsCommand.Execute(null);

		}
	}
}
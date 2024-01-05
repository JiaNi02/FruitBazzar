namespace FruitBazzar1.Views;

public partial class ProductTrackingPage : ContentPage
{
    public ProductTrackingPage()
    {
        InitializeComponent();
        BindingContext = new ProductTrackingViewModel();
    }
}
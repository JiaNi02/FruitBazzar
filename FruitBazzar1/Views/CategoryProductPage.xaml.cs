namespace FruitBazzar1.Views;

public partial class CategoryProductPage : ContentPage
{
    public CategoryProductPage(string categoryName)
    {
        InitializeComponent();
        BindingContext = new CategoryProductViewModel(categoryName);
    }


}
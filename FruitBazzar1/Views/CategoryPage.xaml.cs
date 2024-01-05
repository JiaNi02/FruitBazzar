namespace FruitBazzar1.Views
{
    public partial class CategoryPage : ContentPage
{

    public CategoryPage()
    {
        InitializeComponent();


    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection?[0] is CategoryItem category)
        {
            await Navigation.PushAsync(new CategoryProductPage(category.CategoryName));
        }
    }
}
}

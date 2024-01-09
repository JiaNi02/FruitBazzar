namespace FruitBazzar1.Views
{
    public partial class CategoryPage : ContentPage
    {

        public CategoryPage()
        {
            InitializeComponent();


        }

        private async void ItemTapped(object sender, EventArgs e)
        {
            if (sender is Frame frame && frame.BindingContext is CategoryItem category)
            {
                await Navigation.PushAsync(new CategoryProductPage(category.CategoryName));
            }
        }
    }
}

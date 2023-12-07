namespace FruitBazzar1.Views 
{
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
            BindingContext = new CategoryViewModel();
        }

    }
}

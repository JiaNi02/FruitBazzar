namespace FruitBazzar1.Views;

public partial class CardMethodPage : ContentPage
{
    public CardMethodPage()
    {
        InitializeComponent();
        BindingContext = new CardViewModel();
    }


}
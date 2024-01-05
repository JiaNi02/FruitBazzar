using CommunityToolkit.Maui.Views;

namespace FruitBazzar1.Views;

public partial class EditProfilePage : ContentPage
{
    public EditProfilePage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, true);
    }

    private void OnButtonClick(object sender, EventArgs e)
    {
        this.ShowPopup(new PopUpPage());
    }
}
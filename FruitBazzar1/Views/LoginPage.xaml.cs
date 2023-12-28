using FruitBazzar1.ViewModel;
using System.Windows.Input;

namespace FruitBazzar1.Views;

public partial class LoginPage : ContentPage
{

    public LoginViewModel ViewModel { get; } = new LoginViewModel();

    public LoginPage()
    {
        InitializeComponent();
        BindingContext = ViewModel;
    }

    private async void SignUpLabel_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
    async void TapGestureRecognizer_Tapped(Object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(HomePage), animate: true);
        await Shell.Current.GoToAsync("//MainTab", animate: true);
    }
    //public LoginPage(LoginPageViewModel viewModel)
    //{
    //    InitializeComponent();

    //    this.BindingContext = viewModel;
    //}


}







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
    async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
    //private void BtnLogin_Clicked(object sender, EventArgs e)
    //{
    //     Navigation.PushAsync(new HomePage());
    //}


}







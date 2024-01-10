using FruitBazzar1.Repository;
using FruitBazzar1.ViewModel;
using System.Windows.Input;


namespace FruitBazzar1.Views;

public partial class LoginPage : ContentPage
{
    //readonly IUserRepository userService = new UserService();

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
        await Shell.Current.GoToAsync("//MainTab", animate: true);
    }
}
    //    try
    //    {
    //        // Create an instance of the HTTP client
    //        var httpClient = new HttpClientService().GetPlatformSpecificHttpClient();

    //        // Determine the base URL based on the platform
    //        var baseUrl = DeviceInfo.Platform == DevicePlatform.Android
    //            ? "https://10.0.2.2:7207"
    //            : "https://localhost:7207";

    //        // Construct the API endpoint URL
    //        var apiUrl = $"{baseUrl}/api/User";

    //        // Send HTTP GET request to the API endpoint
    //        var response = await httpClient.GetAsync(apiUrl);

    //        // Check if the request was successful
    //        if (response.IsSuccessStatusCode)
    //        {
    //            // Continue with user login logic

    //            string email = Entry_Email.Text;
    //            if (!email.Contains("@"))
    //            {
    //                await DisplayAlert("Error", "Invalid Email", "Ok");
    //                return;
    //            }

    //            string password = Entry_Password.Text;
    //            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
    //            {
    //                await Shell.Current.DisplayAlert("Error", "All fields required", "Ok");
    //                return;
    //            }

    //            // Perform user login using your userService
    //            Users users = await userService.Login(email, password);

    //            if (users == null)
    //            {
    //                await DisplayAlert("Error", "Credentials are incorrect", "Ok");
    //                return;
    //            }

    //            // Navigate to the desired page after successful login
    //            await Shell.Current.GoToAsync("//MainTab", animate: true);
    //            await DisplayAlert("Login", "Successfully logged in", "Ok");
    //        }
    //        else
    //        {
    //            // Handle the case when the API request fails
    //            await DisplayAlert("Error", "Failed to fetch data from API", "Ok");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        // Handle any exceptions that may occur
    //        await DisplayAlert("Error", ex.Message, "Ok");
    //    }
    //}
   









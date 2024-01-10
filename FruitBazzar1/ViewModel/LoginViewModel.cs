
using FruitBazzar1.Services.Authenticate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FruitBazzar1.ViewModel
{

    public class LoginViewModel : INotifyPropertyChanged
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public ICommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(ExecuteLogin);
        }

        private async void ExecuteLogin()
        {
            await Shell.Current.GoToAsync("//maintab");
            //await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    //public class LoginPageViewModel : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }

    //    private ServiceProvider _serviceProvider;

    //    public LoginPageViewModel(ServiceProvider serviceProvider)
    //    {
    //        UserName = "wanda";
    //        Password = "Abc12345";
    //        IsProcessing = false;

    //        LoginCommand = new Command(() =>
    //        {
    //            if (IsProcessing) return;

    //            if (UserName.Trim() == "" || Password.Trim() == "") return;

    //            IsProcessing = true;
    //            Login().GetAwaiter().OnCompleted(() =>
    //            {
    //                IsProcessing = false;
    //            });
    //        });
    //        this._serviceProvider = serviceProvider;
    //    }

    //    async Task Login()
    //    {
    //        try
    //        {
    //            var request = new AuthenticateRequest
    //            {
    //                LoginId = UserName,
    //                Password = Password,
    //            };
    //            var response = await _serviceProvider.Authenticate(request);
    //            if (response.StatusCode == 200)
    //            {
    //                await Shell.Current.GoToAsync($"ListChatPage?userId={response.Id}");
    //            }
    //            else
    //            {
    //                await AppShell.Current.DisplayAlert("ChatApp", response.StatusMessage, "OK");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            await AppShell.Current.DisplayAlert("ChatApp", ex.Message, "OK");
    //        }
    //    }


}




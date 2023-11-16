
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

                await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }




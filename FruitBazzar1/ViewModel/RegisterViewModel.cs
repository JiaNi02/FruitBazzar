using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string fullName;
        public string Name
        {
            get => fullName;
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private string mobilePhone;
        public string MobilePhone
        {
            get => mobilePhone;
            set
            {
                if (mobilePhone != value)
                {
                    mobilePhone = value;
                    OnPropertyChanged(nameof(MobilePhone));
                }
            }
        }

        private string email;
        public string Email
        {
            get => email;
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        private string password;
        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private bool subscribeToNewsletter;
        public bool SubscribeToNewsletter
        {
            get => subscribeToNewsletter;
            set
            {
                if (subscribeToNewsletter != value)
                {
                    subscribeToNewsletter = value;
                    OnPropertyChanged(nameof(SubscribeToNewsletter));
                }
            }
        }

        public ICommand SubmitCommand => new Command(HandleSubmit);

        private void HandleSubmit(object obj)
        {
            // Add your registration logic here
            // Access ViewModel properties like FullName, MobilePhone, etc.
            // Handle checkbox state using SubscribeToNewsletter

            // For example, display an alert:
            Application.Current.MainPage.DisplayAlert("Registration", "Registration successful!", "OK");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

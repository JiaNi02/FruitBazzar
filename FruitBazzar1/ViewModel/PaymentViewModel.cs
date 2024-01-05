using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    public class PaymentViewModel : BindableObject
    {
        private string _cardNumber;
        private string _expirationDate;
        private string _cvv;

        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (_cardNumber != value)
                {
                    _cardNumber = value;
                    OnPropertyChanged(nameof(CardNumber));
                }
            }
        }

        public string ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                if (_expirationDate != value)
                {
                    _expirationDate = value;
                    OnPropertyChanged(nameof(ExpirationDate));
                }
            }
        }

        public string CVV
        {
            get { return _cvv; }
            set
            {
                if (_cvv != value)
                {
                    _cvv = value;
                    OnPropertyChanged(nameof(CVV));
                }
            }
        }

        public ICommand ProcessPaymentCommand => new Command(ProcessPayment);

        private async void ProcessPayment()
        {
            // Implement your payment processing logic here
            // This is a placeholder for demonstration purposes
            //DisplayAlert("Payment Successful", "Thank you for your purchase!", "OK");

            // Implement your payment processing logic here
            // This is a placeholder for demonstration purposes

            // Assuming payment is successful
            await Application.Current.MainPage.DisplayAlert("Payment Successful", "Thank you for your purchase!", "OK");

            // Navigate back to the home page
            Shell.Current.GoToAsync("//HomePage");
        }

        //private void DisplayAlert(string title, string message, string button)
        //{
        //    Application.Current.MainPage.DisplayAlert(title, message, button);
        //}
    }

}

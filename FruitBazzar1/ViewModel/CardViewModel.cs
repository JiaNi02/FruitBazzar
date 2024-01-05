using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    public class CardViewModel : BaseViewModel
    {
        private bool _isCreditCardSelected;
        private bool _isPayPalSelected;
        private bool _isTouchNGoSelected;

        private string _cardNumber;
        private string _expiryMonth;
        private string _expiryYear;
        private string _cvv;
        private string _firstName;
        private string _lastName;

        public bool IsCreditCardSelected
        {
            get { return _isCreditCardSelected; }
            set { SetProperty(ref _isCreditCardSelected, value); }
        }

        public bool IsPayPalSelected
        {
            get { return _isPayPalSelected; }
            set { SetProperty(ref _isPayPalSelected, value); }
        }

        public bool IsTouchNGoSelected
        {
            get { return _isTouchNGoSelected; }
            set { SetProperty(ref _isTouchNGoSelected, value); }
        }

        public string CardNumber
        {
            get { return _cardNumber; }
            set { SetProperty(ref _cardNumber, value); }
        }

        public string ExpiryMonth
        {
            get { return _expiryMonth; }
            set { SetProperty(ref _expiryMonth, value); }
        }

        public string ExpiryYear
        {
            get { return _expiryYear; }
            set { SetProperty(ref _expiryYear, value); }
        }

        public string CVV
        {
            get { return _cvv; }
            set { SetProperty(ref _cvv, value); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        public ICommand SaveCommand => new Command(OnSave);

        private void OnSave()
        {
            // Handle the save logic here
            Console.WriteLine("Save button clicked!");
        }
    }
}

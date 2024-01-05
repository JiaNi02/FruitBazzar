using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace FruitBazzar1.ViewModel
{
    public partial class CartViewModel : ObservableObject
    {
        public event EventHandler<Product> CartItemRemoved;
        public event EventHandler<Product> CartItemUpdated;
        public event EventHandler CartCleared;
        public ObservableCollection<Product> Items { get; set; } = new();

        [ObservableProperty]
        private double _totalAmount;

        private void RecalculateTotalAmount() => TotalAmount = Items.Sum(i => i.Amount);

        [RelayCommand]
        private void UpdateCartItem(Product product)
        {
            var item = Items.FirstOrDefault(i => i.Name == product.Name);
            if (item is not null)
            {
                item.CartQuantity = product.CartQuantity;
            }
            else
            {
                Items.Add(product.Clone());
            }
            RecalculateTotalAmount();
        }

        [RelayCommand]
        private async void RemoveCartItem(string name)
        {
            var item = Items.FirstOrDefault(i => i.Name == name);
            if (item is not null)
            {
                Items.Remove(item);
                RecalculateTotalAmount();

                CartItemRemoved?.Invoke(this, item);

                var snackbarOptions = new SnackbarOptions
                {
                    CornerRadius = 10,
                    BackgroundColor = Colors.YellowGreen
                };
                var snackbar = Snackbar.Make($"'{item.Name}' removed from cart",
                    () =>
                    {
                        Items.Add(item);
                        RecalculateTotalAmount();
                        CartItemUpdated?.Invoke(this, item);
                    }, "Undo", TimeSpan.FromSeconds(5), snackbarOptions);

                await snackbar.Show();
            }
        }

        [RelayCommand]
        private async Task ClearCart()
        {
            if (await Shell.Current.DisplayAlert("Confirm Clear Cart?", "Do you really want to clear the cart items?", "Yes", "No"))
            {
                Items.Clear();
                RecalculateTotalAmount();
                CartCleared?.Invoke(this, EventArgs.Empty);

                await Toast.Make("Cart Cleared", ToastDuration.Short).Show();
            }
        }

        [RelayCommand]
        private async Task PlaceOrder()
        {
            Items.Clear();
            CartCleared?.Invoke(this, EventArgs.Empty);
            RecalculateTotalAmount();
            await Shell.Current.GoToAsync(nameof(PaymentPage), animate: true);
            //await Shell.Current.GoToAsync($"//{nameof(CheckoutPage)}");
        }

        [RelayCommand]
        public async Task NavProductPage()
        {

            await Shell.Current.GoToAsync(nameof(ProductPage), animate: true);

        }
    }
}
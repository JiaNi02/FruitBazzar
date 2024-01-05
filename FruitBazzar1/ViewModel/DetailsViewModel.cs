using CommunityToolkit.Maui.Alerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    [QueryProperty(nameof(Product), nameof(Product))]
    public partial class DetailsViewModel : ObservableObject, IDisposable
    {
        private readonly CartViewModel _cartViewModel;
        public DetailsViewModel(CartViewModel cartViewModel)
        {
            _cartViewModel = cartViewModel;

            _cartViewModel.CartCleared += OnCartCleared;
            _cartViewModel.CartItemRemoved += OnCartItemRemoved;
            _cartViewModel.CartItemUpdated += OnCartItemUpdated;
        }

        private void OnCartCleared(object? _, EventArgs e) => Product.CartQuantity = 0;

        private void OnCartItemRemoved(object? _, Product p) =>
            OnCartItemChanged(p, 0);

        private void OnCartItemUpdated(object? _, Product p) =>
            OnCartItemChanged(p, p.CartQuantity);

        private void OnCartItemChanged(Product p, int quantity)
        {
            if (p.Name == Product.Name)
            {
                Product.CartQuantity = quantity;
            }
        }

        [ObservableProperty]
        private Product _product;

        [RelayCommand]
        private void AddToCart()
        {
            Product.CartQuantity++;
            _cartViewModel.UpdateCartItemCommand.Execute(Product);
        }

        [RelayCommand]
        private void RemoveFromCart()
        {
            if (Product.CartQuantity > 0)
            {
                Product.CartQuantity--;
                _cartViewModel.UpdateCartItemCommand.Execute(Product);

            }
        }

        [RelayCommand]
        private async Task ViewCart()
        {
            if (Product.CartQuantity > 0)
            {
                await Shell.Current.GoToAsync(nameof(CartPage), animate: true);
            }
            else
            {
                await Toast.Make("Please select the quantity using the plus (+) button", ToastDuration.Short)
                    .Show();
            }

        }

        public void Dispose()
        {
            _cartViewModel.CartCleared -= OnCartCleared;
            _cartViewModel.CartItemRemoved -= OnCartItemRemoved;
            _cartViewModel.CartItemUpdated -= OnCartItemUpdated;
        }
    }
}
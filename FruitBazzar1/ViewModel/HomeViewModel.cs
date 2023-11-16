
using CommunityToolkit.Mvvm.ComponentModel;
using FruitBazzar1.Model;
using FruitBazzar1.Services;
using FruitBazzar1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FruitBazzar1.ViewModel
{
    public partial class HomeViewModel :ObservableObject
    {
        private readonly ProductService _productService;


        public HomeViewModel(ProductService productService)
        {
            _productService = productService;
            Products = new(_productService.GetPopularProducts());
        }
        public ObservableCollection<Product> Products { get; set; }
        [RelayCommand]
        public async Task GoToProductPage(bool fromSearch = false)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(ProductViewModel.FromSearch)] = fromSearch
            };
            await Shell.Current.GoToAsync(nameof(ProductPage), animate: true, parameters);
        }

        [RelayCommand]
        private async Task GoToDetailsPage(Product product)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(DetailsViewModel.Product)] = product
            };
            await Shell.Current.GoToAsync(nameof(DetailsPage), animate: true, parameters);
        }

        [RelayCommand]
        public async Task OnGoToClicked(bool fromSearch = false)
        {
            await Shell.Current.GoToAsync(nameof(ProductPage));
        }
    }

}

using System;
namespace FruitBazzar1.ViewModel
{
    [QueryProperty(nameof(FromSearch),nameof(FromSearch))]
    public partial class ProductViewModel : ObservableObject
    {
        private readonly ProductService _productService;
        public ProductViewModel(ProductService productService)
        {
            _productService = productService;
            Products = new(_productService.GetAllProducts());
        }
        public ObservableCollection<Product> Products { get; set;}
        [ObservableProperty]
        private bool _fromSearch;

        [ObservableProperty]
        private bool _searching;

        [RelayCommand]
        private async Task SearchProducts(string searchTerm)
        {
            Products.Clear();
            Searching = true;
            await Task.Delay(1000);
            foreach(var product in _productService.SearchProducts(searchTerm))
            {
                Products.Add(product);
            }
            Searching = false;
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
    }
}

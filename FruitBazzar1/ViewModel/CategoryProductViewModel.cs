using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    public partial class CategoryProductViewModel : ObservableObject
    {
        private ObservableCollection<Product> _categoryProducts;

        public ObservableCollection<Product> CategoryProducts
        {
            get { return _categoryProducts; }
            set
            {
                if (_categoryProducts != value)
                {
                    _categoryProducts = value;
                    OnPropertyChanged();
                }
            }
        }



        private string _image;
        public string Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }


        private string _price;
        public string Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged();
                }
            }
        }


        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }


        // Default constructor
        public CategoryProductViewModel()
        {
            // You can initialize default values or perform other setup here if needed.
        }

        public CategoryProductViewModel(string categoryName)
        {
            LoadProductsByCategory(categoryName);
        }

        private void LoadProductsByCategory(string categoryName)
        {
            var productService = new ProductService();
            var products = productService.GetProductsByCategory(categoryName);

            CategoryProducts = new ObservableCollection<Product>(products.Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image, // Include the Image property
                Price = p.Price,
                Category = p.Category


            }));


            // Set the title to the selected category
            Title = categoryName;
        }

        [RelayCommand]
        private async Task ViewMore(Product product)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(DetailsViewModel.Product)] = product,
                [nameof(CategoryProductViewModel.Title)] = Title
            };

            

            await Shell.Current.GoToAsync("//MainTab/D_FAULT_Tab32/DetailsPage", animate: true, parameters);
        }
    }
}

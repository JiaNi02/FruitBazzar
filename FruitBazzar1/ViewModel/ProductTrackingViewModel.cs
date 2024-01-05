using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    public class ProductTrackingViewModel : BindableObject
    {
        private ObservableCollection<ProductItem> _trackedProducts;

        public ObservableCollection<ProductItem> TrackedProducts
        {
            get { return _trackedProducts; }
            set
            {
                if (_trackedProducts != value)
                {
                    _trackedProducts = value;
                    OnPropertyChanged();
                }
            }
        }

        // Default constructor
        public ProductTrackingViewModel()
        {
            InitializeTrackedProducts();
        }

        private void InitializeTrackedProducts()
        {
            // Sample tracked product data, replace with your own data
            TrackedProducts = new ObservableCollection<ProductItem>
            {
                new ProductItem { ProductName = "Product A", LastUpdate = DateTime.Now.AddHours(-3) },
                new ProductItem { ProductName = "Product B", LastUpdate = DateTime.Now.AddDays(-1) },
                new ProductItem { ProductName = "Product C", LastUpdate = DateTime.Now.AddHours(-6) },
                // Add more tracked products as needed
            };
        }
    }

    public class ProductItem
    {
        public string ProductName { get; set; }
        public DateTime LastUpdate { get; set; }
        // Add more properties as needed
    }
}
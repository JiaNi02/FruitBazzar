using FruitBazzar1.Model;

namespace FruitBazzar1.Services
{
    public class ProductService
    {
        private readonly static IEnumerable<Product> _products = new List<Product>
        {
            new Product
            { Id = 1,
              Name= "apple",
              Image="apple.png",
              Price= 2
            },
            new Product
            { Id = 2,
              Name= "orange",
              Image="orange.png",
              Price= 10
            },
            new Product
            { Id = 3,
              Name= "banana",
              Image="banana.png",
              Price= 3.5
            },
            new Product
            { Id = 4,
              Name= "papaya",
              Image="papaya.png",
              Price= 4
            },
            new Product
            { Id = 5,
              Name= "rambutan",
              Image="rambutan.png",
              Price= 10
            },
            new Product
            { Id = 6,
              Name= "watermelon",
              Image="watermelon.png",
              Price= 4.5
            },
        };

        public IEnumerable<Product> GetAllProducts() => _products;

        public IEnumerable<Product> GetPopularProducts(int count = 6) =>
            _products.OrderBy(p => Guid.NewGuid()).Take(count);

        public IEnumerable<Product> SearchProducts(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _products
            : _products.Where(p => p.Name.Contains(searchTerm,
                StringComparison.OrdinalIgnoreCase));
    }
}

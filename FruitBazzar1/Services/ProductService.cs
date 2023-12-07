using FruitBazzar1.Model;

namespace FruitBazzar1.Services
{
    public class ProductService
    {
        private readonly static IEnumerable<Product> _products = new List<Product>
        {
            new Product
            { Id = 1,
              Name= "Apple",
              Image="apple.png",
              Price= 2
            },
            new Product
            { Id = 2,
              Name= "Orange",
              Image="orange.png",
              Price= 10
            },
            new Product
            { Id = 3,
              Name= "Banana",
              Image="banana.png",
              Price= 3.5
            },
            new Product
            { Id = 4,
              Name= "Papaya",
              Image="papaya.png",
              Price= 4
            },
            new Product
            { Id = 5,
              Name= "Rambutan",
              Image="rambutan.png",
              Price= 10
            },
            new Product
            { Id = 6,
              Name= "Watermelon",
              Image="watermelon.png",
              Price= 4.5
            },
             new Product
            { Id = 7,
              Name= "Grapefuit",
              Image="grapefuit.png",
              Price= 10
            },
               new Product
            { Id = 8,
              Name= "Langsat",
              Image="langsat.png",
              Price= 10
            },
                 new Product
            { Id = 9,
              Name= "Kiwi",
              Image="kiwi.png",
              Price= 3.5
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

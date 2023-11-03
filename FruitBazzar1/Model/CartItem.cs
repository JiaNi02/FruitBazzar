
using CommunityToolkit.Mvvm.ComponentModel;
namespace FruitBazzar1.Model
{
    public partial class CartItem : ObservableObject
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        private int _quantity;
        public decimal Amount => Price * Quantity;
    }
}

public class Cart {
    public class Root
    {
        public string ProductName { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public string Categories { get; set; }
    }
}
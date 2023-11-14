using CommunityToolkit.Mvvm.ComponentModel;

namespace FruitBazzar1.Model
{
    public partial class Cart : ObservableObject
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

using System;
using CommunityToolkit.Mvvm.ComponentModel;


namespace FruitBazzar1.Model
{
    public partial class Product :ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }



        // Override ToString method to provide a meaningful string representation
        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
        //public short CategoryId { get; set; }

        //public string CategoryName { get; set; }

        private int _cartquantity;
        public int CartQuantity
        {
            get => _cartquantity;
            set
            {
                SetProperty(ref _cartquantity, value);
                OnPropertyChanged(nameof(Amount));
            }
        }

        // 用于表示重量的属性
        private double _weight;

        public double Weight
        {
            get => _weight;
            set
            {
                SetProperty(ref _weight, value);
                OnPropertyChanged(nameof(Amount));
            }
        }


        public double Amount => CartQuantity * Price;
        public Product Clone() => MemberwiseClone() as Product;

    }
}

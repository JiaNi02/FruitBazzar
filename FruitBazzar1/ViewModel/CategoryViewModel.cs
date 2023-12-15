using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FruitBazzar1.ViewModel
{
    public class CategoryViewModel : BindableObject
    {
        private ObservableCollection<CategoryItem> _fruitCategories; 

        public ObservableCollection<CategoryItem> FruitCategories
        {
            get { return _fruitCategories; }
            set
            {
                if (_fruitCategories != value)
                {
                    _fruitCategories = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                if ( _imagePath != value)
                {
                    _imagePath = value;
                    OnPropertyChanged(nameof(ImagePath));
                }
            }
        }

        private string _categoryName;
        public string CategoryName
        {
            get { return _categoryName; }
            set
            {
                if (_categoryName != value)
                {
                    _categoryName = value;
                    OnPropertyChanged(nameof(CategoryName));
                }
            }
        }

        public CategoryViewModel()
        {
            InitializeCategories();
        }

        private void InitializeCategories()
        {
            // Sample fruit categories, replace with your own data
            FruitCategories = new ObservableCollection<CategoryItem>
            {
                new CategoryItem { CategoryName = "Citrus Fruits", ImagePath = "apple.jpg" },
                new CategoryItem { CategoryName = "Berries", ImagePath = "orange.jpg" },
                new CategoryItem { CategoryName = "Tropical Fruits", ImagePath = "orange.jpg" },
                new CategoryItem { CategoryName = "Stone Fruits", ImagePath = "orange.jpg" },
                new CategoryItem { CategoryName = "Melon", ImagePath = "orange.jpg" },
                new CategoryItem { CategoryName = "Apples and Pears", ImagePath = "orange.jpg" },
                new CategoryItem { CategoryName = "Exotic Fruits", ImagePath = "orange.jpg" },
                new CategoryItem { CategoryName = "Stoneless Fruits", ImagePath = "orange.jpg" },
                // Add more categories with respective image paths
            };
        }
    }

    public class CategoryItem
    {
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }
    }
}
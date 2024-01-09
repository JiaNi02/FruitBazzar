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

        private string _pageTitle;
        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                if (_pageTitle != value)
                {
                    _pageTitle = value;
                    OnPropertyChanged();
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
            PageTitle = "Fruit Categories";
        }

        private void InitializeCategories()
        {
            // Sample fruit categories, replace with your own data
            FruitCategories = new ObservableCollection<CategoryItem>
            {
                    new CategoryItem { CategoryName = "Citrus Fruits"},
                    new CategoryItem { CategoryName = "Berries",},
                    new CategoryItem { CategoryName = "Tropical Fruits" },
                    new CategoryItem { CategoryName = "Stone Fruits" },
                    new CategoryItem { CategoryName = "Melon" },
                    new CategoryItem { CategoryName = "Apples and Pears" },
                    new CategoryItem { CategoryName = "Exotic Fruits" },
                    new CategoryItem { CategoryName = "Stoneless Fruits" },
                    // Add more categories with respective image paths
            };
        }


    }


    public class CategoryItem
    {
        public string CategoryName { get; set; }

    }
}

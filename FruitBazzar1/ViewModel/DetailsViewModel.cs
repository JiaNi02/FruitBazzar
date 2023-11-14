using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    [QueryProperty(nameof(Product),nameof(Product))]
    public partial class DetailsViewModel : ObservableObject
    {
        public DetailsViewModel() 
        { 
        }
        [ObservableProperty]
        private Product _product;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.Model
{
    public class Seller
    {
        public string SellerName { get; set; }
        public string ContactNumber { get; set; }
        public ICommand ChatCommand { get; set; }
    }
}

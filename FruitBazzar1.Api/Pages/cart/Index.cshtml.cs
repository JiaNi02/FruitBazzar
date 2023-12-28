using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FruitBazzar1.Api.Models;

namespace FruitBazzar1.Api.Pages.cart
{
    public class IndexModel : PageModel
    {
        private readonly FruitBazzar1.Api.Models.FruitBazzardatabaseContext _context;

        public IndexModel(FruitBazzar1.Api.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

        public IList<CartItem> CartItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CartItem != null)
            {
                CartItem = await _context.CartItem
                .Include(c => c.Customers)
                .Include(c => c.Product).ToListAsync();
            }
        }
    }
}

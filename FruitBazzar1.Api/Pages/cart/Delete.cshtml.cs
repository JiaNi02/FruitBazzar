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
    public class DeleteModel : PageModel
    {
        private readonly FruitBazzar1.Api.Models.FruitBazzardatabaseContext _context;

        public DeleteModel(FruitBazzar1.Api.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CartItem CartItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CartItem == null)
            {
                return NotFound();
            }

            var cartitem = await _context.CartItem.FirstOrDefaultAsync(m => m.Id == id);

            if (cartitem == null)
            {
                return NotFound();
            }
            else 
            {
                CartItem = cartitem;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CartItem == null)
            {
                return NotFound();
            }
            var cartitem = await _context.CartItem.FindAsync(id);

            if (cartitem != null)
            {
                CartItem = cartitem;
                _context.CartItem.Remove(CartItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FruitBazzar1.Api.Models;

namespace FruitBazzar1.Api.Pages.cart
{
    public class CreateModel : PageModel
    {
        private readonly FruitBazzar1.Api.Models.FruitBazzardatabaseContext _context;

        public CreateModel(FruitBazzar1.Api.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomersId"] = new SelectList(_context.Customers, "Id", "Id");
        ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public CartItem CartItem { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CartItem == null || CartItem == null)
            {
                return Page();
            }

            _context.CartItem.Add(CartItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

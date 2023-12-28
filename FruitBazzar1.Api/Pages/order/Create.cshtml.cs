using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FruitBazzar1.Api.Models;

namespace FruitBazzar1.Api.Pages.order
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
        ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
        ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Orders Orders { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Orders == null || Orders == null)
            {
                return Page();
            }

            _context.Orders.Add(Orders);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

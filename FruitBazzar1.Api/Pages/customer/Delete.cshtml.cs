using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FruitBazzar1.Api.Models;

namespace FruitBazzar1.Api.Pages.customer
{
    public class DeleteModel : PageModel
    {
        private readonly FruitBazzar1.Api.Models.FruitBazzardatabaseContext _context;

        public DeleteModel(FruitBazzar1.Api.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Customers Customers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FirstOrDefaultAsync(m => m.Id == id);

            if (customers == null)
            {
                return NotFound();
            }
            else 
            {
                Customers = customers;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }
            var customers = await _context.Customers.FindAsync(id);

            if (customers != null)
            {
                Customers = customers;
                _context.Customers.Remove(Customers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

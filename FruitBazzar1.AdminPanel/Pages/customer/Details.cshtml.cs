using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FruitBazzar1.AdminPanel.Models;

namespace FruitBazzar1.AdminPanel.Pages.customer
{
    public class DetailsModel : PageModel
    {
        private readonly FruitBazzar1.AdminPanel.Models.FruitBazzardatabaseContext _context;

        public DetailsModel(FruitBazzar1.AdminPanel.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

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
    }
}

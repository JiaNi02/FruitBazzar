using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FruitBazzar1.AdminPanel.Models;

namespace FruitBazzar1.AdminPanel.Pages.customer
{
    public class CreateModel : PageModel
    {
        private readonly FruitBazzar1.AdminPanel.Models.FruitBazzardatabaseContext _context;

        public CreateModel(FruitBazzar1.AdminPanel.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customers Customers { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Customers == null || Customers == null)
            {
                return Page();
            }

            _context.Customers.Add(Customers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

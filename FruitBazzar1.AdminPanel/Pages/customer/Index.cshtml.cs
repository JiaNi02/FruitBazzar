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
    public class IndexModel : PageModel
    {
        private readonly FruitBazzar1.AdminPanel.Models.FruitBazzardatabaseContext _context;

        public IndexModel(FruitBazzar1.AdminPanel.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customers = await _context.Customers.ToListAsync();
            }
        }
    }
}

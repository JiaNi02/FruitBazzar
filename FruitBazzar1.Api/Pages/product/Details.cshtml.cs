﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FruitBazzar1.Api.Models;

namespace FruitBazzar1.Api.Pages.product
{
    public class DetailsModel : PageModel
    {
        private readonly FruitBazzar1.Api.Models.FruitBazzardatabaseContext _context;

        public DetailsModel(FruitBazzar1.Api.Models.FruitBazzardatabaseContext context)
        {
            _context = context;
        }

      public Products Products { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            else 
            {
                Products = products;
            }
            return Page();
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections.Generic;
using System.Threading.Tasks;
using web452_assignment1.Data;
using web452_assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace web452_assignment1
{
        public class CatalogueModel : PageModel
        {
            private readonly ApplicationDbContext _context;

            public CatalogueModel(ApplicationDbContext context)
            {
                _context = context;
            }

            public IList<ProductItem> Product { get; set; }

            public async Task OnGetAsync()
            {
                Product = await _context.Product.ToListAsync();
            }
        }
}


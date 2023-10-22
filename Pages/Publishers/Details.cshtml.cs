﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bruj_Tudor_Lab2._1.Data;
using Bruj_Tudor_Lab2._1.Models;

namespace Bruj_Tudor_Lab2._1.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context _context;

        public DetailsModel(Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bruj_Tudor_Lab2._1.Data;
using Bruj_Tudor_Lab2._1.Models;

namespace Bruj_Tudor_Lab2._1.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context _context;

        public CreateModel(Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

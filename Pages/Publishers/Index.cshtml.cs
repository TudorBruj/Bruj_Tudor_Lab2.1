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
    public class IndexModel : PageModel
    {
        private readonly Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context _context;

        public IndexModel(Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}

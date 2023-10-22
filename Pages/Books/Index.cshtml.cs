using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bruj_Tudor_Lab2._1.Data;
using Bruj_Tudor_Lab2._1.Models;

namespace Bruj_Tudor_Lab2._1.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context _context;

        public IndexModel(Bruj_Tudor_Lab2._1.Data.Bruj_Tudor_Lab2_1Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
            }
        }
    }
}

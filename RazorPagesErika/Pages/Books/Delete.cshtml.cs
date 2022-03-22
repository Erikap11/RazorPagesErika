#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesErika.Data;
using RazorPagesErika.Models;

namespace RazorPagesErika.Pages.Books
{
#pragma warning disable 8618
#pragma warning disable 8601
#pragma warning disable 8602
#pragma warning disable 8604
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesErika.Data.RazorPagesErikaContext _context;

        public DeleteModel(RazorPagesErika.Data.RazorPagesErikaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FindAsync(id);

            if (Book != null)
            {
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore 8618
#pragma warning restore 8601
#pragma warning restore 8602
#pragma warning restore 8604
}

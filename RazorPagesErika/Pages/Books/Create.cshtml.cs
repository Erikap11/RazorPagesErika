#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesErika.Data;
using RazorPagesErika.Models;

namespace RazorPagesErika.Pages.Books
{
#pragma warning disable 8618
#pragma warning disable 8602      
    public class CreateModel : PageModel
    {
        private readonly RazorPagesErika.Data.RazorPagesErikaContext _context;

        public CreateModel(RazorPagesErika.Data.RazorPagesErikaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore 8618
#pragma warning restore 8602
}

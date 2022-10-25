using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tomi_Lavinia_Lab2.Data;
using Tomi_Lavinia_Lab2.Models;

namespace Tomi_Lavinia_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Tomi_Lavinia_Lab2.Data.Tomi_Lavinia_Lab2Context _context;

        public CreateModel(Tomi_Lavinia_Lab2.Data.Tomi_Lavinia_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

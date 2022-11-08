﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tomi_Lavinia_Lab2.Data;
using Tomi_Lavinia_Lab2.Models;

namespace Tomi_Lavinia_Lab2.Pages.Borrowings
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
            var bookList = _context.Book
     .Include(b => b.Author)
     .Select(x => new
     {
         x.ID,
         BookFullName = x.Title + " - " + x.Author.LastName + " " +
    x.Author.FirstName
     });

            ViewData["BookID"] = new SelectList(bookList, "ID",
           "BookFullName");
            ViewData["MemberID"] = new SelectList(_context.Member, "ID",
           "FullName");
            return Page();
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Borrowing.Add(Borrowing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

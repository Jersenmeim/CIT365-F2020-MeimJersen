﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public DetailsModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public scriptures scriptures { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            scriptures = await _context.scriptures.FirstOrDefaultAsync(m => m.Scriptureid == id);

            if (scriptures == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

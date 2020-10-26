using System;
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
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<scriptures> Scriptures { get;set; }

        public async Task OnGetAsync(string search)
        {
            var book = from m in _context.scriptures
                       select m;
            if (!string.IsNullOrEmpty(search))
            {
                book = book.Where(s => s.Book.Contains(search));
            }
            Scriptures = await book.ToListAsync();
        }
    }
}

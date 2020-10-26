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



        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<scriptures> Scriptures { get;set; }

        public async Task OnGetAsync(string search, string searchNote, string sortOrder)
        {
            var book = from m in _context.scriptures
                       select m;
            var notes = from m in _context.scriptures
                       select m;


            if (!string.IsNullOrEmpty(search))
            {
                book = book.Where(s => s.Book.Contains(search));
            }


            if (!string.IsNullOrEmpty(searchNote))
            {
                notes = notes.Where(s => s.Notes.Contains(searchNote));
            }


            Scriptures = await book.ToListAsync();
            Scriptures = await notes.ToListAsync();


            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<scriptures> scripturesList = from s in _context.scriptures
                                             select s;

            switch (sortOrder)
            {
                case "name_desc":
                    scripturesList = scripturesList.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scripturesList = scripturesList.OrderBy(s => s.DateCreated);
                    break;
                case "date_desc":
                    scripturesList = scripturesList.OrderByDescending(s => s.DateCreated);
                    break;
                default:
                    scripturesList = scripturesList.OrderBy(s => s.Book);
                    break;
            }

            Scriptures = await scripturesList.AsNoTracking().ToListAsync();






        }
    }
}

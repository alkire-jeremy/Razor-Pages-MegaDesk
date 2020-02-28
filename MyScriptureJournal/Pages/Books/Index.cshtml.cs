using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        [BindProperty(SupportsGet = true)]
        public string BookSearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string NoteSearchString { get; set; }

        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {

            // If sortOrder argument is empty, default sort order to "book_descending", if it is not empty, default sort order to an empty string.
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_descending" : "";

            // If sortOrder equals date, set sortOrder to "date_descending", if it is not empty, default to "date_ascending".
            DateSort = sortOrder == "Date" ? "date_descending" : "date_ascending";

            var books = from b in _context.Book
                         select b;

            if (!string.IsNullOrEmpty(BookSearchString))
            {
                books = books.Where(s => s.BookName.Contains(BookSearchString));
            }

            if (!string.IsNullOrEmpty(NoteSearchString))
            {
                books = books.Where(s => s.Note.Contains(NoteSearchString));
            }

            switch (sortOrder)
            {
                case "book_descending":
                    books = books.OrderByDescending(b => b.BookName);
                    break;
                case "date_ascending":
                    books = books.OrderBy(b => b.DateAdded);
                    break;
                case "date_descending":
                    books = books.OrderByDescending(b => b.DateAdded);
                    break;
                default:
                    // Sort by ascending book name, by default.
                    books = books.OrderBy(b => b.BookName);
                    break;
            }

            Book = await books.ToListAsync();
        }
    }
}

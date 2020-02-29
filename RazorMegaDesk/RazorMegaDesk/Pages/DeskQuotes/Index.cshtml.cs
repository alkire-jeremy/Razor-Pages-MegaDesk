using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly RazorMegaDesk.Models.RazorMegaDeskContext _context;

        public IndexModel(RazorMegaDesk.Models.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // Implement searching by customer name.
            var quotes = from q in _context.DeskQuote
                select q;
            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(q => q.CustomerName.Contains(SearchString));
            }

            // Implement sorting.
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            switch (sortOrder)
            {
                case "name_desc":
                    quotes = quotes.OrderByDescending(dq => dq.CustomerName);
                    break;
                case "Date":
                    quotes = quotes.OrderBy(dq => dq.QuoteDate);
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(dq => dq.QuoteDate);
                    break;
                default:
                    quotes = quotes.OrderBy(dq => dq.CustomerName);
                    break;
            }

            DeskQuote = await quotes.ToListAsync();
        }
    }
}

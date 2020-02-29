using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorMegaDesk.Models;

namespace RazorMegaDesk.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly RazorMegaDesk.Models.RazorMegaDeskContext _context;
        public const int SQUAREPRICE = 1;
        public const int DRAWERPRICE = 50;

        public CreateModel(RazorMegaDesk.Models.RazorMegaDeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote deskQuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            deskQuote.QuoteTotal = CalculateQuoteTotal(deskQuote);

            _context.DeskQuote.Add(deskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public double CalculateQuoteTotal(DeskQuote quote)
        {
            double rushPrice = 0;
            double materialPrice = 0;
            double surfaceArea = quote.Width* quote.Depth;

            List<int> materialPriceList = new List<int>() { 200, 100, 50, 300, 125 };

            // Calculate materialPrice.
            if (quote.DeskMaterial == "Oak")
            {
                materialPrice = materialPriceList[0];
            }
            else if (quote.DeskMaterial == "Laminate")
            {
                materialPrice = materialPriceList[1];
            }
            else if (quote.DeskMaterial == "Pine")
            {
                materialPrice = materialPriceList[2];
            }
            else if (quote.DeskMaterial == "Rosewood")
            {
                materialPrice = materialPriceList[3];
            }
            else if (quote.DeskMaterial == "Veneer")
            {
                materialPrice = materialPriceList[4];
            }

            double[] rushPrices = {60, 70, 80, 40, 50, 60, 30, 35, 40};

            // Calculate rushPrice.
            switch (quote.RushDays)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        rushPrice = rushPrices[0];
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        rushPrice = rushPrices[1];
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushPrice = rushPrices[2];
                    }
                    break;
                case 5:
                    if (surfaceArea < 1000)
                    {
                        rushPrice = rushPrices[3];
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        rushPrice = rushPrices[4];
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushPrice = rushPrices[5];
                    }
                    break;
                case 7:
                    if (surfaceArea < 1000)
                    {
                        rushPrice = rushPrices[6];
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        rushPrice = rushPrices[7];
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushPrice = rushPrices[8];
                    }
                    break;
                default:
                    Console.WriteLine("Something probably went wrong.");
                    break;
            }

            if (surfaceArea > 1000)
            {
                double total = (surfaceArea * SQUAREPRICE) + (quote.NumberOfDrawers * DRAWERPRICE) + rushPrice + materialPrice + 200;
                return total;
            }
            else
            {
                double total = (quote.NumberOfDrawers * DRAWERPRICE) + rushPrice + materialPrice + 200;
                return total;
            }
        }
    }
}
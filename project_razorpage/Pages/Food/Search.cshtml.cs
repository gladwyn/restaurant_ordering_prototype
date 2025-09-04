using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project_razorpage.Models;

namespace project_razorpage
{
    public class SearchFoodModel : PageModel
    {
        private readonly project_razorpage.Data.project_razorpageContext _context;
        public SearchFoodModel(project_razorpage.Data.project_razorpageContext context)
        {
            _context = context;
        }
        public IList<Food> Food { get; set; }
        [BindProperty]
        public string TitleSearchString { get; set; }
        [BindProperty]
        public string GenreSearchString { get; set; }
        [BindProperty]
        public decimal PriceSearchString { get; set; }
        // NOTE List can be used in place of IList
        public async Task OnGetAsync()
        {
            var movies = from m in _context.Food
                         select m;

           Food = await movies.ToListAsync();
        }
        public async Task OnPostAsync()
        {
            var movies = from m in _context.Food
                         select m; //LINQ select is to read
            if (!string.IsNullOrEmpty(TitleSearchString))
            {
                movies = from m in _context.Food
                         where m.FoodName.Contains(TitleSearchString)
                         select m;
            }
            else if (!string.IsNullOrEmpty(GenreSearchString))
            {
                movies = from m in _context.Food
                         where m.FoodDescription.Contains(GenreSearchString)
                         select m;
            }
            else if (!string.IsNullOrEmpty(PriceSearchString.ToString()))
            {
                movies = from m in _context.Food
                         where m.Price < PriceSearchString
                         select m;
            }
           else if (!string.IsNullOrEmpty(GenreSearchString) &&
 !string.IsNullOrEmpty(PriceSearchString.ToString()))
            {
                movies = from m in _context.Food
                         where m.FoodDescription.Contains(GenreSearchString) &&
                        m.Price < PriceSearchString
                         select m;
            }

            Food = await movies.ToListAsync();
        }
    }
}
    

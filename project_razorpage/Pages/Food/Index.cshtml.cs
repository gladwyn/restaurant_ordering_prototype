using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project_razorpage.Data;
using project_razorpage.Models;

namespace project_razorpage
{
    public class IndexFoodModel : PageModel
    {
        private readonly project_razorpage.Data.project_razorpageContext _context;

        public IndexFoodModel(project_razorpage.Data.project_razorpageContext context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; }

        public async Task OnGetAsync()
        {
            Food = await _context.Food.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using project_razorpage.Data;
using project_razorpage.Models;

namespace project_razorpage
{
    public class CreateOrderModel : PageModel
    {
        private readonly project_razorpage.Data.project_razorpageContext _context;
        [BindProperty]
        public DateTime ReservationDateTime
        { get; set; } = System.DateTime.Now;
        public string[] Chickenpopcornsize = { "XS", "S", "M", "L", "XL" };
        public CreateOrderModel(project_razorpage.Data.project_razorpageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

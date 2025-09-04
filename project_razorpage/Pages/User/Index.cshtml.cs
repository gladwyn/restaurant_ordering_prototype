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
    public class IndexUserModel : PageModel
    {
        private readonly project_razorpage.Data.project_razorpageContext _context;

        public IndexUserModel(project_razorpage.Data.project_razorpageContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}

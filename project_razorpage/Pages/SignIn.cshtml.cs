using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project_razorpage.Models;
/*this for sessions*/
using Microsoft.AspNetCore.Http;

namespace project_razorpage
{
    public class SignInModel : PageModel
    {
        private readonly project_razorpage.Data.project_razorpageContext _context;
        public SignInModel(project_razorpage.Data.project_razorpageContext context)
        {
            _context = context;
        }
        public IList<User> User { get; set; }
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var movies = from m in _context.User select m;
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                movies = from m in _context.User
                         where m.Username.Equals("abc") && m.Password.Equals("123")
                         select m;
                User = await movies.ToListAsync();
                if (User != null)
                {
                    Msg = "successfully";
                    HttpContext.Session.SetString("username", Username);
                    return RedirectToPage("Index");
                }
                if (User == null)
                {
                    Msg = "incorrect";
                    return Page();
                }
                return Page();
            }
            else
            {
                Msg = "empty string";
                return Page();
            }
         


        }
       
    }
}
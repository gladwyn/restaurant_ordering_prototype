using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
namespace project_razorpage
{
    public class LogoutModel : PageModel
    {
        public string Username { get; set; }

        public IActionResult OnGet()
        {
            Username = HttpContext.Session.GetString("username");
            HttpContext.Session.Clear();
            return RedirectToPage("Index");
        }
    }
}
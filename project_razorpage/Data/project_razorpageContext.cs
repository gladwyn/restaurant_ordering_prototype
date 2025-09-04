using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project_razorpage.Models;

namespace project_razorpage.Data
{
    public class project_razorpageContext : DbContext
    {
        public project_razorpageContext (DbContextOptions<project_razorpageContext> options)
            : base(options)
        {
        }

        public DbSet<project_razorpage.Models.Order> Order { get; set; }

        public DbSet<project_razorpage.Models.Food> Food { get; set; }

        public DbSet<project_razorpage.Models.User> User { get; set; }
    }
}

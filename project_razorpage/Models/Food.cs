using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace project_razorpage.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public decimal Price { get; set; }
    }
}

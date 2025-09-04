using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace project_razorpage.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public string Address { get; set; }
        public string Cutlery { get; set; }
        public string DeliveryDate { get; set; }
        public int Qty { get; set; }
        public string Request { get; set; }

        public string Size { get; set; }
    } 
}

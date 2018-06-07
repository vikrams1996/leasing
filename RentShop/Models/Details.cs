using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentShop.Models
{
    public class Details
    {
        public int Id { get; set; }

        public ApplicationUser Rental { get; set; }

        public string Company { get; set; }

        public string Contact { get; set; }

        public string Email { get; set; }

        public ShopRequired ShopRequired { get; set; }

        public UnitsRequired UnitsRequired { get; set; }

        public int Area { get; set; }

        public int monthlyRevenue { get; set; }

        public string payThrough { get; set; }

    }
}
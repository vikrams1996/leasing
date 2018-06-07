using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentShop.Models;
namespace RentShop.ViewModel
{
    public class RentFormViewModel
    {
        public string Company { get; set; }

        public string Contact { get; set; }

        public string Email { get; set; }

        public string Area { get; set; }

        public string monthlyRevenue { get; set; }

        public string payThrough { get; set; }

        public int ShopRequired { get; set; }

        public IEnumerable<ShopRequired> Shops { get; set; }

        public int UnitsRequired { get; set; }

        public IEnumerable<UnitsRequired> Units { get; set; }
    }
}
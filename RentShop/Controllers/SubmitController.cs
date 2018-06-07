using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RentShop.Models;
using RentShop.ViewModel;
namespace RentShop.Controllers
{
    public class SubmitController : Controller
    {
        private ApplicationDbContext _Context;



        public SubmitController()
        {
            _Context = new ApplicationDbContext();

        }
        [Authorize]
        public ActionResult Final()
        {
            var shopsSoldd = _Context.Details.Include(g => g.Rental).Include(g => g.ShopRequired);
            return View(shopsSoldd);
        }

      
    }
}
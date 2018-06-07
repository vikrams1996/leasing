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
    public class HomeController : Controller
    {
        private ApplicationDbContext _Context;


        
        public HomeController()
        {
            _Context = new ApplicationDbContext();

        }
       [Authorize]
        public ActionResult Index()
        {
            var shopsSold = _Context.Details.Include(g => g.Rental).Include(g=>g.ShopRequired);
            return View(shopsSold);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
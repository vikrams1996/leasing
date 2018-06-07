using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentShop.Models;
using RentShop.ViewModel;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace RentShop.Controllers
{
    public class RentController : Controller
    {
        private ApplicationDbContext _Context;

        public RentController()
        {
            _Context = new ApplicationDbContext();
        }
  

        public ActionResult Rent()
        {
            var viewModel = new RentFormViewModel
            {
                Shops = _Context.ShopRequired.ToList(),
                Units= _Context.UnitsRequired.ToList()

            };

            return View(viewModel);
        }

        [HttpPost]
       
        public ActionResult Rent (RentFormViewModel ViewModel)
        {
            var rentalId = User.Identity.GetUserId();
            var shops = _Context.ShopRequired.Single(s => s.Id == ViewModel.ShopRequired);
            var units = _Context.UnitsRequired.Single(u => u.Id == ViewModel.UnitsRequired);
            var rental = _Context.Users.Single(u => u.Id == rentalId);

            var rent = new Details
            {
                Rental=rental,
                Company = ViewModel.Company,
                Contact =ViewModel.Contact,
                Email=ViewModel.Email,
                ShopRequired=shops,
                UnitsRequired=units


            };
            _Context.Details.Add(rent);
            _Context.SaveChanges();




            return RedirectToAction("Final" ,"Submit");
        }
        
    }
}
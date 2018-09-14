using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nackowski.BusinessLayer;
using Nackowski.DAL.Model;

namespace Nackowski.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IBusinessService _businessService;

        public AdminController(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult CreateAuction()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateAuction(AuctionModel model)
        {
            model.SlutDatumString = model.SlutDatum.ToString();
            model.StartDatumString = model.StartDatum.ToString();
            var result = _businessService.CreateAuction(model);
            return RedirectToAction("Dashboard","Admin");
        }

        public IActionResult EditAuction()
        {

            return View();
        }

        [HttpPut]
        public IActionResult EditAuction(AuctionModel updatedModel)
        {
            var result = _businessService.EditAuction(updatedModel);
            return RedirectToAction("Dashboard", "Admin");
        }
    }
}
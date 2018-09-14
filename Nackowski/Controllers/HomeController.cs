using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nackowski.Models;
using System.Net.Http;
using Nackowski.BusinessLayer;
using Nackowski.DAL.Model;
using Nackowski.ViewModels;

namespace Nackowski.Controllers
{
    public class HomeController : Controller
    {
        private IBusinessService _businessService;

        public HomeController(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        public async Task<IActionResult> Index()
        {
            List<AuctionModel> auctions = new List<AuctionModel>();
           auctions =  await _businessService.GetAuctions();
            
            return View(auctions);
        }

        public IActionResult FindAuctions(string searchInput)
        {
            var searchResults = new List<AuctionWithBidsVM();
            searchResults._businessService.FindAuctions(searchInput);
            return View(searchResults);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

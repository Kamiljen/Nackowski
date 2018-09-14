using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nackowski.DAL.Model;

namespace Nackowski.ViewModels
{
    public class AuctionWithBidsVM
    {
        public AuctionModel Auction { get; set; }
        public List<BidModel> Bids { get; set; }
    }
}

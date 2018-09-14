using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nackowski.DAL.Model;
using Nackowski.DAL;
using System.Net.Http;
using Nackowski.ViewModels;

namespace Nackowski.BusinessLayer
{
    public class BusinessService : IBusinessService
    {
        private NackowsksisApi _api;
        public BusinessService()
        {
            _api = new NackowsksisApi();
        }

        public Task<HttpResponseMessage> CreateAuction(AuctionModel model)
        {
             
            return _api.CreateAuction(model);
        }

        public Task<HttpResponseMessage> CreateBid(int auctionId)
        {
            return _api.CreateBid(auctionId);
        }

        public Task<HttpResponseMessage> DeleteBid(int bidId)
        {
            return _api.DeleteBid(bidId);
        }

        public Task<HttpResponseMessage> EditAuction(AuctionModel model)
        {
            return _api.EditAuction(model);
        }

        public List<AuctionWithBidsVM> FindAuctions(string searchString)
        {
            var searchResults = new List<AuctionWithBidsVM>();
            var allAuctions = GetAuctions().Result;
            var filteredAuctions = allAuctions.Where(x => x.Titel.Contains(searchString) || x.Beskrivning.Contains(searchString));
            foreach(var auction in filteredAuctions)
            {
                searchResults.Add(new AuctionWithBidsVM
                {
                    Auction = auction, Bids = GetBids(auction.AuktionID).Result
                });

            }

            return searchResults;
        }

        public Task<AuctionModel> GetAuction(int auctionId)
        {
            return _api.GetAuction(auctionId);
        }

        public Task<List<AuctionModel>> GetAuctions()
        {
            return _api.GetAuctions();
        }

        public Task<BidModel> GetBid(int auctionId, int bidId)
        {
            return _api.GetBid(auctionId, bidId);
        }

        public Task<List<BidModel>> GetBids(int auctionId)
        {
            return _api.GetBids(auctionId);
        }
    }
}

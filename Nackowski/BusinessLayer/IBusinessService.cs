﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Nackowski.DAL.Model;
using Nackowski.ViewModels;

namespace Nackowski.BusinessLayer
{
    public interface IBusinessService
    {
        Task<HttpResponseMessage> CreateAuction(AuctionModel model);
        Task<HttpResponseMessage> EditAuction(AuctionModel model);
        Task<HttpResponseMessage> DeleteBid(int bidId);

        Task<HttpResponseMessage> CreateBid(int auctionId);

        List<AuctionWithBidsVM> FindAuctions(string searchString);
        Task<List<AuctionModel>> GetAuctions();
        Task<AuctionModel> GetAuction(int auctionId);
        Task<List<BidModel>> GetBids(int auctionId);
        Task<BidModel> GetBid(int auctionId, int bidId);
    }
}

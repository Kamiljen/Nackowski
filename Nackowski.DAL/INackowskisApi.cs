using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nackowski.DAL.Model;




namespace Nackowski.DAL
{
    public interface INackowskisApi
    {
        Task<HttpResponseMessage> CreateAuction(AuctionModel model);
        Task<HttpResponseMessage> EditAuction(AuctionModel model);

        Task<HttpResponseMessage> CreateBid(int auctionId);
        Task<HttpResponseMessage> DeleteBid(int bidId);

        Task<List<AuctionModel>> GetAuctions();
        Task<AuctionModel> GetAuction(int auctionId);
        Task<List<BidModel>> GetBids(int auctionId);
        Task<BidModel> GetBid(int auctionId, int bidId);
    }
}

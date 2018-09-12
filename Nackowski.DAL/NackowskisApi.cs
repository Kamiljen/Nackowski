
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Nackowski.DAL.Model;
using Newtonsoft.Json;

namespace Nackowski.DAL
{
    public class NackowsksisApi : INackowskisApi
    {
            private static HttpClient client = new HttpClient();
            private readonly string ApiNackowskisKey;
            private readonly Uri ApiAuctionBaseAdress;
            private readonly Uri ApiBidBaseAdress;

            

            public NackowsksisApi()
            {
                ApiNackowskisKey = "1060";
                ApiAuctionBaseAdress = new Uri($"http://nackowskis.azurewebsites.net/api/Auktion/");
                ApiBidBaseAdress = new Uri($"http://nackowskis.azurewebsites.net/api/Bud");
                

            }

            public async Task<HttpResponseMessage> CreateAuction(AuctionModel auction)
            {
            client.BaseAddress = ApiAuctionBaseAdress;
            client.DefaultRequestHeaders.Accept.Clear();

            var model = new AuctionModel { Beskrivning = "", Gruppkod = 1060, SkapadAv = "Admin", StartDatum = DateTime.Now, SlutDatum = DateTime.Now, Titel = "Omega TimeStop", Utropspris = 19000 };

            var json = JsonConvert.SerializeObject(auction);

            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            return await client.PostAsync("", stringContent);

            //HttpResponseMessage response = await client.PostAsJsonAsync(ApiNackowskisKey, model);

            //response.EnsureSuccessStatusCode();

            
        }

        public Task<HttpResponseMessage> CreateBid(int auctionId)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DeleteBid(int bidId)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> EditAuction(AuctionModel model)
        {
            client.BaseAddress = ApiAuctionBaseAdress;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

            var json = JsonConvert.SerializeObject(model);

            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            return await client.PutAsync("", stringContent);
        }

        public async Task<AuctionModel> GetAuction(int auctionId)
        {
            client.BaseAddress = ApiAuctionBaseAdress;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(AuctionModel));
            HttpResponseMessage response = await client.GetAsync("/" + ApiNackowskisKey + "/" + auctionId);
            response.EnsureSuccessStatusCode();
                
            Stream responseStream = response.Content.ReadAsStreamAsync().Result;
            
            return (AuctionModel)serializer.ReadObject(responseStream);
            
        }

        public async Task<List<AuctionModel>> GetAuctions()
        {
            client.BaseAddress = ApiAuctionBaseAdress;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<AuctionModel>));
            HttpResponseMessage response = await client.GetAsync(ApiNackowskisKey);
            response.EnsureSuccessStatusCode();
            
            Stream responseStream = response.Content.ReadAsStreamAsync().Result;

            return (List<AuctionModel>)serializer.ReadObject(responseStream);
        }

        public Task<BidModel> GetBid(int auctionId, int bidId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BidModel>> GetBids(int auctionId)
        {
            throw new NotImplementedException();
        }
    }
}

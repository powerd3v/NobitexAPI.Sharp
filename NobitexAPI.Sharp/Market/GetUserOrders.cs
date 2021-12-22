using RestSharp;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using NobitexAPI.Sharp.PublicMarket;
using System.Collections.Generic;

namespace NobitexAPI.Sharp.Market
{
    public class GetUserOrders
    {
        public async Task<GetUserOrdersResponse> GetUserOrdersRequestAsync(NobitexClient nobitex, GetUserOrdersCeredinals ceredinals)
        {
            try
            {
                //insert request here
                var client = new RestClient(nobitex.Base_URL + "/market/orders/list");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                var body = $"{{\"type\":\"{ceredinals.Type}\",\"status\":\"{ceredinals.Status}\",\"srcCurrency\":\"{ceredinals.SourceCurrency}\",\"dstCurrency\":\"{ceredinals.DestonationCurrency}\",\"details\":{ceredinals.DetailsID}}}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetUserOrdersResponse>(response.Content);
                    return await Task.FromResult(result);
                }
                catch (Exception e)
                {
                    var ex = JsonConvert.DeserializeObject<NobitexAPI.Sharp.Exceptions.NobitexException>(response.Content);
                    throw new Exception(ex.detail + "\r\n" + e.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    public enum OrderStatus { all, open, close, done }
    public class GetUserOrdersCeredinals
    {
        public OrderType Type { get; set; }
        public OrderStatus Status { get; set; }
        public CurrencyType SourceCurrency { get; set; }
        public CurrencyType DestonationCurrency { get; set; }
        public int DetailsID { get; set; }
    }
    public class GetUserOrdersResponse
    {
        public string status { get; set; }
        public List<Order> orders { get; set; }
    }
}

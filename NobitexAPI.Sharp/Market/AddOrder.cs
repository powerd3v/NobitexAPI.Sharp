using RestSharp;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using NobitexAPI.Sharp.PublicMarket;

namespace NobitexAPI.Sharp.Market
{
    public class AddOrder
    {
        public async Task<AddOrderResponse> AddOrderRequestAsync(NobitexClient nobitex, OrderCeredinals ceredinals)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/market/orders/add");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                var body = $"{{\"type\":\"{ceredinals.Type}\",\"srcCurrency\":\"{ceredinals.SourceCurrency}\",\"dstCurrency\":\"{ceredinals.DestonationCurrency}\",\"amount\":\"{ceredinals.Amount}\",\"price\":{ceredinals.Price}}}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<AddOrderResponse>(response.Content);
                    return await Task.FromResult(result);
                }
                catch (Exception e)
                {
                    var ex = JsonConvert.DeserializeObject<NobitexAPI.Sharp.Exceptions.AddOrderException>(response.Content);
                    throw new Exception(ex.message + "\r\n" + e.Message);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
    public enum OrderType { buy, sell }
    public enum OrderExecution { limit, market }
    public class Order
    {
        public string type { get; set; }
        public string srcCurrency { get; set; }
        public string dstCurrency { get; set; }
        public string price { get; set; }
        public string amount { get; set; }
        public string totalPrice { get; set; }
        public int matchedAmount { get; set; }
        public string unmatchedAmount { get; set; }
        public int id { get; set; }
        public string status { get; set; }
        public bool partial { get; set; }
        public int fee { get; set; }
        public string user { get; set; }
        public DateTime created_at { get; set; }
    }
    public class AddOrderResponse
    {
        public string status { get; set; }
        public Order order { get; set; }
    }
    public class OrderCeredinals
    {
        public OrderType Type { get; set; }
        public OrderExecution Execution { get; set; }
        public CurrencyType SourceCurrency { get; set; }
        public CurrencyType DestonationCurrency { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
    }
}

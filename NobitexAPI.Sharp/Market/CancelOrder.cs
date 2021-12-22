using RestSharp;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using NobitexAPI.Sharp.PublicMarket;

namespace NobitexAPI.Sharp.Market
{
    public class CancelOrder
    {
        public async Task<CancelOrderResponse> CancelOrderRequestAsync(NobitexClient nobitex, CancelOrderCeredinals ceredinals)
        {
            try
            {
                //insert request here
                var client = new RestClient(nobitex.Base_URL + "/market/orders/cancel-old");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                var body = $"{{\"execution\":\"{ceredinals.execution}\",\"srcCurrency\":\"{ceredinals.srcCurrency}\",\"dstCurrency\":\"{ceredinals.dstCurrency}\",\"hours\":{ceredinals.hours}}}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<CancelOrderResponse>(response.Content);
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
    public class CancelOrderResponse
    {
        public string status { get; set; }
    }
    public class CancelOrderCeredinals
    {
        public double hours { get; set; }
        public OrderExecution execution { get; set; }
        public CurrencyType srcCurrency { get; set; }
        public CurrencyType dstCurrency { get; set; }
    }
}

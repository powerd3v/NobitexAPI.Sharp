using RestSharp;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using NobitexAPI.Sharp.PublicMarket;

namespace NobitexAPI.Sharp.Market
{
    public class UpdateOrder
    {
        public async Task<UpdateOrderResponse> UpdateOrderRequestAsync(NobitexClient nobitex, UpdateOrderCeredinals ceredinals)
        {
            try
            {
                //insert request here
                var client = new RestClient(nobitex.Base_URL + "/market/orders/update-status");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                var body = $"{{\"order\":{ceredinals.orderID},\"status\":\"{ceredinals.orderStatus}\"}}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<UpdateOrderResponse>(response.Content);
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
    public class UpdateOrderResponse
    {
        public string status { get; set; }
        public string updatedStatus { get; set; }
    }
    public class UpdateOrderCeredinals
    {
        public int orderID { get; set; }
        public UpdateOrderStatusType orderStatus { get; set; }
    }
    public enum UpdateOrderStatusType { active, cancel}
}

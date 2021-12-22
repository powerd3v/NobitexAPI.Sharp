using RestSharp;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NobitexAPI.Sharp.Market
{
    public class GetOrdersStatus
    {
        public async Task<GetOrdersStatusResponse> GetOrdersStatusRequestAsync(NobitexClient nobitex, int waletID)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/market/orders/status");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                var body = $"{{\"id\":\"{waletID}\"}}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetOrdersStatusResponse>(response.Content);
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
    public class GetOrdersStatusResponse
    {
        public string status { get; set; }
        public Order order { get; set; }
    }
}

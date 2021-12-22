using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NobitexAPI.Sharp.User
{
    public class AddCard
    {
        public async Task<AddCardResponse> AddCardRequestAsync(NobitexClient nobitex, string bankName, long cardNumber)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/cards-add");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                var body = $"{{\"number\":\"{cardNumber}\",\"bank\":\"{bankName}\"}}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<AddCardResponse>(response.Content);
                    return await Task.FromResult(result);
                }
                catch (Exception e)
                {
                    var ex = JsonConvert.DeserializeObject<Exceptions.NobitexException>(response.Content);
                    throw new Exception(ex.detail + "\r\n" + e.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    public class AddCardResponse
    {
        public string status { get; set; }
    }
}

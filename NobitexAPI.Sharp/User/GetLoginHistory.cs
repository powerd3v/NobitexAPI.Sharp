using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NobitexAPI.Sharp.User
{
    public class GetLoginHistory
    {
        public async Task<GetLoginHistoryResponse> GetLoginHistoryRequestAsync(NobitexClient nobitex)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/login-attempts");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetLoginHistoryResponse>(response.Content);
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
    public class Attempt
    {
        public string ip { get; set; }
        public string username { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
    }

    public class GetLoginHistoryResponse
    {
        public string status { get; set; }
        public List<Attempt> attempts { get; set; }
    }
}

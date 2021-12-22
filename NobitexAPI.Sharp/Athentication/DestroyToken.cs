using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;

namespace NobitexAPI.Sharp.Athentication
{
    public class DestroyToken
    {
        public async Task<string> DestroyTokenRequestAsync(NobitexClient nobitex)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/auth/logout/");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<DestroyResponse>(response.Content);
                    return await Task.FromResult(result.message);
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
    public class DestroyResponse
    {
        public string detail { get; set; }
        public string message { get; set; }
    }
}

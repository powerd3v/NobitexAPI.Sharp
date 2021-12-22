using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using NobitexAPI.Sharp.PublicMarket;

namespace NobitexAPI.Sharp.Walets
{
    public class GenerateBlockchainAddress
    {
        public async Task<GenerateBlockchainAddressResponse> GenerateBlockchainAddressRequestAsync(NobitexClient nobitex, int walletID)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/wallets/generate-address");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AlwaysMultipartFormData = true;
                request.AddParameter("wallet", $"{walletID}");
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GenerateBlockchainAddressResponse>(response.Content);
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
    public class GenerateBlockchainAddressResponse
    {
        public string status { get; set; }
        public string address { get; set; }
    }
}

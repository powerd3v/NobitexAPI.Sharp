using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace NobitexAPI.Sharp.Walets
{
    public class GetDeposits
    {
        public async Task<GetDepositsResponse> GetDepositsRequestAsync(NobitexClient nobitex, int walletID)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/wallets/deposits/list");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AlwaysMultipartFormData = true;
                request.AddParameter("wallet", $"{walletID}");
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetDepositsResponse>(response.Content);
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
    public class Deposit
    {
        public string txHash { get; set; }
        public string address { get; set; }
        public bool confirmed { get; set; }
        public Transaction transaction { get; set; }
        public string currency { get; set; }
        public string blockchainUrl { get; set; }
        public int confirmations { get; set; }
        public int requiredConfirmations { get; set; }
        public string amount { get; set; }
    }

    public class Withdraw
    {
        public int id { get; set; }
        public string blockchain_url { get; set; }
        public bool is_cancelable { get; set; }
        public string status { get; set; }
        public string amount { get; set; }
        public DateTime createdAt { get; set; }
        public int wallet_id { get; set; }
        public string currency { get; set; }
        public string address { get; set; }
    }

    public class GetDepositsResponse
    {
        public string status { get; set; }
        public List<Deposit> deposits { get; set; }
        public List<Withdraw> withdraws { get; set; }
    }
}

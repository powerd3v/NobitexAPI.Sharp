using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace NobitexAPI.Sharp.Walets
{
    public class GetTransactions
    {
        public async Task<GetTransactionsResponse> GetTransactionsRequestAsync(NobitexClient nobitex, int WaletID)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/wallets/transactions/list");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AlwaysMultipartFormData = true;
                request.AddParameter("wallet", $"{WaletID}");
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetTransactionsResponse>(response.Content);
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
    public class Transaction
    {
        public string currency { get; set; }
        public DateTime created_at { get; set; }
        public string calculatedFee { get; set; }
        public int id { get; set; }
        public string amount { get; set; }
        public string description { get; set; }
    }

    public class GetTransactionsResponse
    {
        public List<Transaction> transactions { get; set; }
        public string status { get; set; }
    }
}

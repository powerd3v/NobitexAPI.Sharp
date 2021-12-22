using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NobitexAPI.Sharp.User
{
    public class GetUserLimits
    {
        public async Task<GetUserLimitsResponse> GetUserLimitsRequestAsync(NobitexClient nobitex)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/limitations");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetUserLimitsResponse>(response.Content);
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
    public class Features
    {
        public bool crypto_trade { get; set; }
        public bool rial_trade { get; set; }
        public bool coin_deposit { get; set; }
        public bool rial_deposit { get; set; }
        public bool coin_withdrawal { get; set; }
        public bool rial_withdrawal { get; set; }
    }

    public class WithdrawRialDaily
    {
        public string used { get; set; }
        public string limit { get; set; }
    }

    public class WithdrawCoinDaily
    {
        public string used { get; set; }
        public string limit { get; set; }
    }

    public class WithdrawTotalDaily
    {
        public string used { get; set; }
        public string limit { get; set; }
    }

    public class WithdrawTotalMonthly
    {
        public string used { get; set; }
        public string limit { get; set; }
    }

    public class Limits
    {
        public WithdrawRialDaily withdrawRialDaily { get; set; }
        public WithdrawCoinDaily withdrawCoinDaily { get; set; }
        public WithdrawTotalDaily withdrawTotalDaily { get; set; }
        public WithdrawTotalMonthly withdrawTotalMonthly { get; set; }
    }

    public class Limitations
    {
        public string userLevel { get; set; }
        public Features features { get; set; }
        public Limits limits { get; set; }
    }

    public class GetUserLimitsResponse
    {
        public string status { get; set; }
        public Limitations limitations { get; set; }
    }

}

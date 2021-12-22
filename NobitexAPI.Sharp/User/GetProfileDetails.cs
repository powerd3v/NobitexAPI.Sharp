using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace NobitexAPI.Sharp.User
{
    public class GetProfileDetails
    {
        public async Task<GetProfileDetailsResponse> GetProfileDetailsRequestAsync(NobitexClient nobitex)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/profile");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetProfileDetailsResponse>(response.Content);
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
    public class BankCard
    {
        public string number { get; set; }
        public string bank { get; set; }
        public string owner { get; set; }
        public bool confirmed { get; set; }
        public string status { get; set; }
    }

    public class BankAccount
    {
        public int id { get; set; }
        public string number { get; set; }
        public string shaba { get; set; }
        public string bank { get; set; }
        public string owner { get; set; }
        public bool confirmed { get; set; }
        public string status { get; set; }
    }

    public class Verifications
    {
        public bool email { get; set; }
        public bool phone { get; set; }
        public bool mobile { get; set; }
        public bool identity { get; set; }
        public bool selfie { get; set; }
        public bool bankAccount { get; set; }
        public bool bankCard { get; set; }
        public bool address { get; set; }
        public bool city { get; set; }
    }

    public class PendingVerifications
    {
        public bool email { get; set; }
        public bool phone { get; set; }
        public bool mobile { get; set; }
        public bool identity { get; set; }
        public bool selfie { get; set; }
        public bool bankAccount { get; set; }
        public bool bankCard { get; set; }
    }

    public class Options
    {
        public string fee { get; set; }
        public string feeUsdt { get; set; }
        public bool isManualFee { get; set; }
        public bool tfa { get; set; }
        public bool socialLoginEnabled { get; set; }
    }

    public class Profile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nationalCode { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string city { get; set; }
        public List<BankCard> bankCards { get; set; }
        public List<BankAccount> bankAccounts { get; set; }
        public Verifications verifications { get; set; }
        public PendingVerifications pendingVerifications { get; set; }
        public Options options { get; set; }
        public bool withdrawEligible { get; set; }
    }

    public class TradeStats
    {
        public string monthTradesTotal { get; set; }
        public int monthTradesCount { get; set; }
    }

    public class GetProfileDetailsResponse
    {
        public string status { get; set; }
        public Profile profile { get; set; }
        public TradeStats tradeStats { get; set; }
    }


}

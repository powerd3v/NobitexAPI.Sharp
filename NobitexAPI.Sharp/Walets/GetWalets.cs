using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using NobitexAPI.Sharp.PublicMarket;
using NobitexAPI.Sharp;
using System.Text;

namespace NobitexAPI.Sharp.Walets
{
    public class GetWalets
    {
        public async Task<GetWaletsResponse> GetWaletsRequestAsync(NobitexClient nobitex)
        {
            try
            {
                var rest = new RestClient(nobitex.Base_URL + "/users/wallets/list");
                rest.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                IRestResponse response = rest.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetWaletsResponse>(response.Content);
                    if (result != null)
                    {
                        return await Task.FromResult(result);
                    }
                    else
                    {
                        throw new Exception(response.Content);
                    }
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
        public async Task<GetWaletsResponse> GetWaletsRequestAsync(NobitexClient nobitex, List<CurrencyType> currencies)
        {
            try
            {
                string currencyList = "";
                foreach (var item in currencies)
                {
                    currencyList += $"{item},";
                }
                currencyList = currencyList.Remove(currencyList.Length - 1, 1);
                var client = new RestClient(nobitex.Base_URL + "/v2/wallets");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("currencies", currencyList);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetWaletsResponse>(response.Content);
                    return await Task.FromResult(result);
                }
                catch (Exception)
                {
                    var ex = JsonConvert.DeserializeObject<Exceptions.NobitexException>(response.Content);
                    throw new Exception(ex.detail);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    public class Wallet
    {
        public string activeBalance { get; set; }
        public string blockedBalance { get; set; }
        public string user { get; set; }
        public string currency { get; set; }
        public int id { get; set; }
        public string balance { get; set; }
        public int rialBalance { get; set; }
        public int rialBalanceSell { get; set; }
        public object depositAddress { get; set; }
    }

    public class GetWaletsResponse
    {
        public string status { get; set; }
        public List<Wallet> wallets { get; set; }
    }
}

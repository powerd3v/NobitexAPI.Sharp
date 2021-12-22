using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;

namespace NobitexAPI.Sharp.PublicMarket
{
    public class GetTreaders
    {
        public async Task<GetTreadersResponse> GetTreadersRequestAsync(NobitexClient nobitex,SymbolsType symbol)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/v2/trades");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AlwaysMultipartFormData = true;
                request.AddParameter("symbol", symbol.ToString());
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetTreadersResponse>(response.Content);
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
    
    public class Trade
    {
        public object time { get; set; }
        public string price { get; set; }
        public string volume { get; set; }
        public string type { get; set; }
    }

    public class GetTreadersResponse
    {
        public string status { get; set; }
        public List<Trade> trades { get; set; }
    }
}

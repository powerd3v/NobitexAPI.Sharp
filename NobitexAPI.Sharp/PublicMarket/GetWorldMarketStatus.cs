using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;

namespace NobitexAPI.Sharp.PublicMarket
{
    public class GetWorldMarketStatus
    {
        public async Task<GetWorldMarketStatusResponse> GetWorldMarketStatusRequestAsync(NobitexClient nobitex)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/market/global-stats");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetWorldMarketStatusResponse>(response.Content);
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
    public class Markets
    {
        public Binance binance { get; set; }
    }

    public class Kraken
    {
        public string price { get; set; }
    }

    public class Btc
    {
        public Kraken kraken { get; set; }
    }

    public class Eth
    {
        public Kraken kraken { get; set; }
    }

    public class Ltc
    {
        public Kraken kraken { get; set; }
    }

    public class Usdt
    {
        public Kraken kraken { get; set; }
    }

    public class Xrp
    {
        public Kraken kraken { get; set; }
    }

    public class Bch
    {
        public Kraken kraken { get; set; }
    }

    public class Bnb
    {
        public Kraken kraken { get; set; }
    }

    public class Eos
    {
        public Kraken kraken { get; set; }
    }

    public class Xlm
    {
        public Kraken kraken { get; set; }
    }

    public class Etc
    {
        public Kraken kraken { get; set; }
    }

    public class Trx
    {
        public Kraken kraken { get; set; }
    }

    public class Pmn
    {
        public Kraken kraken { get; set; }
    }

    public class Doge
    {
        public Kraken kraken { get; set; }
    }

    public class Uni
    {
        public Kraken kraken { get; set; }
    }

    public class Dai
    {
        public Kraken kraken { get; set; }
    }

    public class Link
    {
        public Kraken kraken { get; set; }
    }

    public class Dot
    {
        public Kraken kraken { get; set; }
    }

    public class Aave
    {
        public Kraken kraken { get; set; }
    }

    public class Ada
    {
        public Kraken kraken { get; set; }
    }

    public class Shib
    {
        public Kraken kraken { get; set; }
    }

    public class GetWorldMarketStatusResponse
    {
        public string status { get; set; }
        public Markets markets { get; set; }
        public Btc btc { get; set; }
        public Eth eth { get; set; }
        public Ltc ltc { get; set; }
        public Usdt usdt { get; set; }
        public Xrp xrp { get; set; }
        public Bch bch { get; set; }
        public Bnb bnb { get; set; }
        public Eos eos { get; set; }
        public Xlm xlm { get; set; }
        public Etc etc { get; set; }
        public Trx trx { get; set; }
        public Pmn pmn { get; set; }
        public Doge doge { get; set; }
        public Uni uni { get; set; }
        public Dai dai { get; set; }
        public Link link { get; set; }
        public Dot dot { get; set; }
        public Aave aave { get; set; }
        public Ada ada { get; set; }
        public Shib shib { get; set; }
    }


}

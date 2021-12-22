using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;

namespace NobitexAPI.Sharp.PublicMarket
{
    public class GetNobitexMarketStatus
    {
        public async Task<GetNobitexMarketStatusResponse> GetNobitexMarketStatusRequestAsync(CurrencyType SourceCurrency,CurrencyType DestonationCurrency)
        {
            try
            {
                var client = new RestClient("https://api.nobitex.ir/market/stats");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddParameter("srcCurrency", SourceCurrency.ToString());
                request.AddParameter("dstCurrency", DestonationCurrency.ToString());
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetNobitexMarketStatusResponse>(response.Content);
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

    public class BtcUsdt
    {
        public bool isClosed { get; set; }
        public string bestSell { get; set; }
        public string bestBuy { get; set; }
        public string volumeSrc { get; set; }
        public string volumeDst { get; set; }
        public string latest { get; set; }
        public string dayLow { get; set; }
        public string dayHigh { get; set; }
        public string dayOpen { get; set; }
        public string dayClose { get; set; }
        public string dayChange { get; set; }
    }

    public class Stats
    {
        [JsonProperty("btc-usdt")]
        public BtcUsdt BtcUsdt { get; set; }
    }

    public class Binance
    {
        public double mkr { get; set; }
        public double srm { get; set; }
        public double keep { get; set; }
        public double c98 { get; set; }
        public double sfp { get; set; }
        public double _1000xec { get; set; }
        public double xem { get; set; }
        public double zen { get; set; }
        public double eth { get; set; }
        public double mtl { get; set; }
        public double bat { get; set; }
        public double enj { get; set; }
        public double rsr { get; set; }
        public double omg { get; set; }
        public double ata { get; set; }
        public double iost { get; set; }
        public double doge { get; set; }
        public double algo { get; set; }
        public double ankr { get; set; }
        public double chz { get; set; }
        public double zrx { get; set; }
        public double avax { get; set; }
        public double sc { get; set; }
        public double bzrx { get; set; }
        public double tomo { get; set; }
        public double ar { get; set; }
        public double celo { get; set; }
        public double sxp { get; set; }
        public double ocean { get; set; }
        public double dot { get; set; }
        public double unfi { get; set; }
        public double alpha { get; set; }
        public double one { get; set; }
        public double bts { get; set; }
        public double egld { get; set; }
        public double ren { get; set; }
        public double kava { get; set; }
        public double neo { get; set; }
        public double bch { get; set; }
        public double cvc { get; set; }
        public double sushi { get; set; }
        public double sol { get; set; }
        public double nkn { get; set; }
        public double fil { get; set; }
        public double aave { get; set; }
        public double hot { get; set; }
        public double gtc { get; set; }
        public double gala { get; set; }
        public double vet { get; set; }
        public double bel { get; set; }
        public double yfii { get; set; }
        public double snx { get; set; }
        public double bake { get; set; }
        public double stmx { get; set; }
        public double reef { get; set; }
        public double ogn { get; set; }
        public double luna { get; set; }
        public double rlc { get; set; }
        public double xtz { get; set; }
        public double eos { get; set; }
        public double coti { get; set; }
        public double storj { get; set; }
        public double hnt { get; set; }
        public double arpa { get; set; }
        public double dash { get; set; }
        public double mana { get; set; }
        public double celr { get; set; }
        public double grt { get; set; }
        public double _1inch { get; set; }
        public double defi { get; set; }
        public double ksm { get; set; }
        public double lina { get; set; }
        public double atom { get; set; }
        public double chr { get; set; }
        public double iotx { get; set; }
        public double xmr { get; set; }
        public double ftm { get; set; }
        public double iota { get; set; }
        public double btcdom { get; set; }
        public double ctk { get; set; }
        public double uni { get; set; }
        public double trx { get; set; }
        public double ont { get; set; }
        public double crv { get; set; }
        public double knc { get; set; }
        public double rvn { get; set; }
        public double theta { get; set; }
        public double icx { get; set; }
        public double skl { get; set; }
        public double klay { get; set; }
        public double waves { get; set; }
        public double tlm { get; set; }
        public double ada { get; set; }
        public double alice { get; set; }
        public double mask { get; set; }
        public double lrc { get; set; }
        public double near { get; set; }
        public double audio { get; set; }
        public double nu { get; set; }
        public double ctsi { get; set; }
        public double btt { get; set; }
        public double matic { get; set; }
        public double akro { get; set; }
        public double bal { get; set; }
        public double zil { get; set; }
        public double dgb { get; set; }
        public double xlm { get; set; }
        public double dent { get; set; }
        public double qtum { get; set; }
        public double ltc { get; set; }
        public double flm { get; set; }
        public double rune { get; set; }
        public double zec { get; set; }
        public double shib { get; set; }
        public double axs { get; set; }
        public double band { get; set; }
        public double etc { get; set; }
        public double trb { get; set; }
        public double comp { get; set; }
        public double icp { get; set; }
        public double link { get; set; }
        public double hbar { get; set; }
        public double xrp { get; set; }
        public double dodo { get; set; }
        public double ray { get; set; }
        public double dydx { get; set; }
        public double yfi { get; set; }
        public double btc { get; set; }
        public double lit { get; set; }
        public double sand { get; set; }
        public double blz { get; set; }
        public double bnb { get; set; }
        public int usdt { get; set; }
        public double lpt { get; set; }
    }

    public class Global
    {
        public Binance binance { get; set; }
    }

    public class GetNobitexMarketStatusResponse
    {
        public string status { get; set; }
        public Stats stats { get; set; }
        public Global global { get; set; }
    }

    public enum CurrencyType
    {
        usd, rls, btc, eth, ltc, usdt, xrp, bch, bnb, eos, doge, xlm, trx, ada, xmr, xem, iota, etc, dash, zec, neo, qtum, xtz
    }
}

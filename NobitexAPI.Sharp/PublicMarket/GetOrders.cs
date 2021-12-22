using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NobitexAPI.Sharp.PublicMarket
{
    public class GetOrders
    {
        public async Task<object> GetOrdersRequestAsync(NobitexClient nobitex,SymbolsType symbol)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/v2/orderbook/"+symbol.ToString());
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                try
                {
                    if (symbol != SymbolsType.all)
                    {
                        var result = JsonConvert.DeserializeObject<OrderBookResponse>(response.Content);
                        return await Task.FromResult(result);
                    }
                    else
                    {
                        var result = JsonConvert.DeserializeObject<OrderBookAllResponse>(response.Content);
                        return await Task.FromResult(result);
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
    }
    public enum SymbolsType
    {
        all, BTCIRT, ETHIRT, LTCIRT, XRPIRT, BCHIRT, BNBIRT,
        EOSIRT, XLMIRT, ETCIRT, TRXIRT, DOGEIRT, UNIIRT, 
        DAIIRT, LINKIRT, DOTIRT, AAVEIRT, ADAIRT, SHIBIRT, 
        USDTIRT, BTCUSDT, ETHUSDT, LTCUSDT, XRPUSDT, BCHUSDT, 
        BNBUSDT, EOSUSDT, XLMUSDT, ETCUSDT, TRXUSDT, PMNUSDT, 
        DOGEUSDT, UNIUSDT, DAIUSDT, LINKUSDT, DOTUSDT, 
        AAVEUSDT, ADAUSDT, SHIBUSDT
    }
    public class OrderBookResponse : IOrder
    {
        public string status { get; set; }
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class BTCIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class ETHIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class LTCIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class USDTIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class XRPIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class BCHIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class BNBIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class EOSIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class XLMIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class ETCIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class TRXIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class DOGEIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class UNIIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class DAIIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class LINKIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class DOTIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class AAVEIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class ADAIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class SHIBIRT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class BTCUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class ETHUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class LTCUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class XRPUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class BCHUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class BNBUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class EOSUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class XLMUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class ETCUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class TRXUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class PMNUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class DOGEUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class UNIUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class DAIUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class LINKUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class DOTUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class AAVEUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class ADAUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }

    public class SHIBUSDT : IOrder
    {
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }
    public interface IOrder
    {
         List<List<string>> bids { get; set; }
         List<List<string>> asks { get; set; }
    }
    public class OrderBookAllResponse
    {
        public string status { get; set; }
        public BTCIRT BTCIRT { get; set; }
        public ETHIRT ETHIRT { get; set; }
        public LTCIRT LTCIRT { get; set; }
        public USDTIRT USDTIRT { get; set; }
        public XRPIRT XRPIRT { get; set; }
        public BCHIRT BCHIRT { get; set; }
        public BNBIRT BNBIRT { get; set; }
        public EOSIRT EOSIRT { get; set; }
        public XLMIRT XLMIRT { get; set; }
        public ETCIRT ETCIRT { get; set; }
        public TRXIRT TRXIRT { get; set; }
        public DOGEIRT DOGEIRT { get; set; }
        public UNIIRT UNIIRT { get; set; }
        public DAIIRT DAIIRT { get; set; }
        public LINKIRT LINKIRT { get; set; }
        public DOTIRT DOTIRT { get; set; }
        public AAVEIRT AAVEIRT { get; set; }
        public ADAIRT ADAIRT { get; set; }
        public SHIBIRT SHIBIRT { get; set; }
        public BTCUSDT BTCUSDT { get; set; }
        public ETHUSDT ETHUSDT { get; set; }
        public LTCUSDT LTCUSDT { get; set; }
        public XRPUSDT XRPUSDT { get; set; }
        public BCHUSDT BCHUSDT { get; set; }
        public BNBUSDT BNBUSDT { get; set; }
        public EOSUSDT EOSUSDT { get; set; }
        public XLMUSDT XLMUSDT { get; set; }
        public ETCUSDT ETCUSDT { get; set; }
        public TRXUSDT TRXUSDT { get; set; }
        public PMNUSDT PMNUSDT { get; set; }
        public DOGEUSDT DOGEUSDT { get; set; }
        public UNIUSDT UNIUSDT { get; set; }
        public DAIUSDT DAIUSDT { get; set; }
        public LINKUSDT LINKUSDT { get; set; }
        public DOTUSDT DOTUSDT { get; set; }
        public AAVEUSDT AAVEUSDT { get; set; }
        public ADAUSDT ADAUSDT { get; set; }
        public SHIBUSDT SHIBUSDT { get; set; }
        public List<IOrder> Orders()
        {
            var list = new List<IOrder>();
            list.Add(BTCIRT); list.Add(ETHIRT); list.Add(LTCIRT); list.Add(USDTIRT); list.Add(XRPIRT);
            list.Add(BCHIRT); list.Add(BNBIRT); list.Add(EOSIRT); list.Add(XLMIRT); list.Add(ETCIRT);
            list.Add(TRXIRT); list.Add(DOGEIRT); list.Add(UNIIRT); list.Add(LINKIRT); list.Add(DOTIRT);
            list.Add(AAVEIRT); list.Add(ADAIRT); list.Add(SHIBIRT); list.Add(BTCUSDT); list.Add(ETHUSDT);
            list.Add(LTCUSDT); list.Add(XRPUSDT); list.Add(BCHUSDT); list.Add(BNBUSDT); list.Add(EOSUSDT);
            list.Add(XLMUSDT); list.Add(ETCUSDT); list.Add(TRXUSDT); list.Add(PMNUSDT); list.Add(DOGEUSDT);
            list.Add(UNIUSDT); list.Add(DAIUSDT); list.Add(LINKUSDT); list.Add(DOTUSDT); list.Add(AAVEUSDT);
            list.Add(ADAUSDT); list.Add(SHIBUSDT);
            return list;
        }
    }
}

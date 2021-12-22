using RestSharp;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NobitexAPI.Sharp.PublicMarket
{
    public class GetOHLC
    {
        public async Task<GetOHLCResponse> GetOHLCRequestAsync(NobitexClient nobitex,OHLCCredinals credinals)
        {
            try
            {
                string resolutionData = "D";
                if (credinals.resolution == ResolutionType.OneDay)
                {
                    resolutionData = "D";
                }
                else if (credinals.resolution == ResolutionType.OneHour)
                {
                    resolutionData = "60";
                }
                else if (credinals.resolution == ResolutionType.SixHours)
                {
                    resolutionData = "360";
                }
                else if (credinals.resolution == ResolutionType.ThreeDays)
                {
                    resolutionData = "3D";
                }
                else if (credinals.resolution == ResolutionType.ThreeHours)
                {
                    resolutionData = "180";
                }
                else if (credinals.resolution == ResolutionType.TwelveHours)
                {
                    resolutionData = "720";
                }
                else if (credinals.resolution == ResolutionType.TwoDays)
                {
                    resolutionData = "2D";
                }
                else
                {
                    resolutionData = "D";
                }
                string baseUrl = nobitex.Base_URL + $"/market/udf/history?symbol={credinals.symbol}&resolution={resolutionData}&from={credinals.FromTime}&to={credinals.ToTime}";
                var client = new RestClient(baseUrl);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<GetOHLCResponse>(response.Content);
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
    public class OHLCCredinals
    {
        public SymbolsType symbol { get; set; }
        public ResolutionType resolution { get; set; }
        public long FromTime { get; set; }
        public long ToTime { get; set; }
    }
    public enum ResolutionType
    {
        OneHour, SixHours, ThreeHours, TwelveHours,
        OneDay, TwoDays, ThreeDays
    }
    public class GetOHLCResponse
    {
        public string s { get; set; }
        public List<int> t { get; set; }
        public List<double> c { get; set; }
        public List<double> o { get; set; }
        public List<double> h { get; set; }
        public List<double> l { get; set; }
        public List<double> v { get; set; }
    }
}

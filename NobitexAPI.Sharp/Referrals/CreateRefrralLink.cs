using RestSharp;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NobitexAPI.Sharp.Referrals
{
    public class CreateRefrralLink
    {
        //public async Task<CreateRefrralLinkResponse> CreateRefrralLinkRequestAsync(string Token)
        //{
        //    try
        //    {
        //        //insert request here
        //        var client = new RestClient("https://api.nobitex.ir/users/get-referral-code");
        //        client.Timeout = -1;
        //        var request = new RestRequest(Method.GET);
        //        request.AddHeader("Authorization", Token);
        //        IRestResponse response = client.Execute(request);
        //        try
        //        {
        //            var result = JsonConvert.DeserializeObject<CreateRefrralLinkResponse>(response.Content);
        //            return await Task.FromResult(result);
        //        }
        //        catch (Exception)
        //        {

        //            var ex = JsonConvert.DeserializeObject<NobitexAPI.Sharp.Exceptions.NobitexException>(response.Content);
        //            throw new Exception(ex.detail);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}

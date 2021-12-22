using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using System;

namespace NobitexAPI.Sharp.User
{
    public class AddBankAccount
    {
        public async Task<BankAccountResponse> AddBankAccountRequestAsync(NobitexClient nobitex, string bankName, long AccountNumber, string Shaba)
        {
            try
            {
                var client = new RestClient(nobitex.Base_URL + "/users/accounts-add");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Token {nobitex.API_KEY}");
                request.AddHeader("content-type", "application/json");
                var body = $"{{\"number\":\"{AccountNumber}\",\"shaba\":\"{Shaba}\",\"bank\":\"{bankName}\"}}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<BankAccountResponse>(response.Content);
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
    public class BankAccountResponse
    {
        public string status { get; set; }
    }
}

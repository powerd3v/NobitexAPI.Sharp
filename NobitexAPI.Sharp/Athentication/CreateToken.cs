using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;

namespace NobitexAPI.Sharp.Athentication
{
    public class CreateToken
    {
        public async Task<CreateTokenResponse> CreateTokenRequestAsync(TokenCeredinals ceredinals)
        {
            try
            {
                string baseUrl = "";
                if (ceredinals.Nobitex_API_Type == API_Type.TestNet)
                {
                    baseUrl = "https://testnetapi.nobitex.ir";
                }
                else
                {
                    baseUrl = "https://api.nobitex.ir";
                }
                var client = new RestClient(baseUrl + "/auth/login/");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("X-TOTP", $"{ceredinals.OTP}");
                request.AlwaysMultipartFormData = true;
                request.AddParameter("username", ceredinals.UserName);
                request.AddParameter("password", ceredinals.Password);
                request.AddParameter("remember", ceredinals.LongTimeToken.ToString());
                request.AddParameter("captcha", ceredinals.Captcha.ToString());
                IRestResponse response = client.Execute(request);
                try
                {
                    var result = JsonConvert.DeserializeObject<CreateTokenResponse>(response.Content);
                    if(result.key==null)
                    {
                        throw new Exception("Invalid Credinals!");
                    }
                    else
                    {
                        return await Task.FromResult(result);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(JsonConvert.DeserializeObject<Exceptions.NobitexException>(response.Content).detail + "\r\n" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    public class CreateTokenResponse
    {
        public string status { get; set; }
        public string key { get; set; }
        public string device { get; set; }
    }
    public class TokenCeredinals
    {
        public string OTP { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public RememberType LongTimeToken { get; set; }
        public CaptchaType Captcha { get; set; }
        public API_Type Nobitex_API_Type { get; set; }
    }
    public enum RememberType
    {
        yes,
        no
    }
    public enum CaptchaType
    {
        api
    }
}

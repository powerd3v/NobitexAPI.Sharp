using System;

namespace NobitexAPI.Sharp
{
    public enum API_Type
    {
        TestNet,
        RealAccount
    }
    public class NobitexClient
    {
        public string API_KEY { get; set; }
        public string Base_URL { get; set; }
        public API_Type Nobitex_API_Type { get; set; }
        public NobitexClient(string api_key, API_Type type = API_Type.RealAccount)
        {
            Nobitex_API_Type = type;
            if (type == API_Type.TestNet)
            {
                Base_URL = "https://testnetapi.nobitex.ir";
            }
            else
            {
                Base_URL = "https://api.nobitex.ir";
            }
            API_KEY = api_key;
        }
    }
}

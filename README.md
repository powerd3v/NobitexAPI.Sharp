


This is a .NET library for the Nobitex cryptocurrency platform. It contains all functionality available through the Nobitex API, including public data endpoints, market order placing/canceling, and wallet interaction. 

### Installing  

Simply add the NobitexAPI.Sharp package to your project and begin using all of the APIs. 

### How To Use 

Once installed, you can use this library to connect to the Nobitex API and access it's many features. 

For instance, to get information about a specific market pair: 

```
public async Task GetTicker()
{
    NobitexApiClient ApiClient = new NobitexApiClient();
    var Ticker = await ApiClient.MarketPublic.GetTickerAsync("ETH_IRR");
    Console.WriteLine(Ticker);
}
```

The library also supports wallet interaction, market orders, and order cancelation: 

```
public async Task PlaceOrder(string apiKey, string apiSecret)
{
    NobitexApiClient ApiClient = new NobitexApiClient(apiKey, apiSecret);
    await ApiClient.Order.LimitOrderAsync("ETH_IRR", 10m, 550000m, EconomicOrderSide.Buy);
}
```

Finally, the library is available in multiple languages and can be used to interact with different endpoints. 

### Contributing

If you want to contribute to NobitexAPI.Sharp by submitting bug fixes, feature enhancements, etc, please fork the repository and submit a pull request. We look forward to see what contributions you can offer the project!

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace HiTrader
{
    public class BitfinexTrader
    {
        public List<Coin> GetTickers()
        {
            var coins = new List<Coin>();
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
            var url = "https://api-pub.bitfinex.com/v2/tickers?symbols=ALL";
            Task<string> response = httpClient.GetStringAsync(url);
            var data = JArray.Parse(response.Result);
            foreach (var obj in data)
            {
                var symbol = obj[0].Value<string>();
                if (symbol[0].ToString().ToLower().Equals("t"))
                {
                    coins.Add(new Coin
                    {
                        Symbol = obj[0].Value<string>(),
                        High = obj[9].Value<double>(),
                        Low = obj[10].Value<double>(),
                        Volume = obj[8].Value<double>(),
                        Bid = obj[1].Value<double>(),
                        BidSize = obj[2].Value<double>(),
                    });
                }
                else
                {
                    coins.Add(new Coin
                    {
                        Symbol = obj[0].Value<string>(),
                        High = obj[12].Value<double>(),
                        Low = obj[13].Value<double>(),
                        Volume = obj[11].Value<double>(),
                        Bid = obj[2].Value<double>(),
                        BidSize = obj[4].Value<double>(),
                    });
                }
                
            }
            return coins;
        }
    }
}
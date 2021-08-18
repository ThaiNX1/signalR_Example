using APITest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Services
{
    public class BinanceServices
    {
        public static List<CoinsModel> GetData(CoinsModelRequest coinRequest)
        {
            var coins = coinRequest.Name.Split(',');
            var result = new List<CoinsModel>();
            foreach (var coin in coins)
            {
                var apiUrl = "https://api.binance.com/api/v3/ticker/24hr?symbol=" + coin +"USDT";
                var client = new RestClient(apiUrl);
                client.ClearHandlers();
                var request = new RestRequest(Method.GET);
                request.Parameters.Clear();
                //request.RequestFormat = DataFormat.Json;
                var response = client.Execute(request);
                var _coin = JsonConvert.DeserializeObject<CoinsModel>(response.Content);
                result.Add(_coin);
            }
            return result;
        }
    }
}

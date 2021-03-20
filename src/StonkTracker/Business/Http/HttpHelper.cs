using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using StonkTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonkTracker.Business.Http
{
    public static class HttpHelper
    {
        private static readonly string BaseUrl = Startup.StaticConfig.GetValue<string>("BaseUrl");
        private static readonly string ApiKey = Startup.StaticConfig.GetValue<string>("AlphaApiKey");


        public static async Task<Overview> GetOverview(string company)
        {
            try
            {
                var client = new RestClient(BaseUrl);
                var request = new RestRequest("query");
                request.AddParameter("function", "OVERVIEW");
                request.AddParameter("symbol", company);
                request.AddParameter("apikey", ApiKey);

                return await client.GetAsync<Overview>(request);
            }
            catch (System.Exception)
            {
                return null;
            }

        }


        public static async Task<IEnumerable<CompositeTimeSeriesModel>> GetTimeSeries(string symbol, string interval)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("query");
            request.AddParameter("function", "TIME_SERIES_INTRADAY");
            request.AddParameter("symbol", symbol);
            request.AddParameter("interval", interval);
            request.AddParameter("apikey", ApiKey);

            var json = await client.GetAsync<string>(request);
            var par = JsonConvert.DeserializeObject(json);

            var jObject = JObject.FromObject(par);
            var list = jObject["Time Series (5min)"].Value<JObject>();

            var dates = list.Properties().Select(x => x.Name).ToList();

            var compositeModels = new List<CompositeTimeSeriesModel>();
            foreach (var elem in dates)
                compositeModels.Add(new CompositeTimeSeriesModel(DateTime.Parse(elem), list[elem].ToObject<TimeSeriesModel>()));
                
            return compositeModels;
        }
    }
}

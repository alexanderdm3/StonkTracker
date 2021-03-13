using Microsoft.Extensions.Configuration;
using RestSharp;
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
    }
}

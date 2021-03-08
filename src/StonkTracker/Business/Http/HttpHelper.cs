using RestSharp;

namespace StonkTracker.Business.Http
{
    public class HttpHelper
    {
        private static readonly string BaseUrl = Startup.StaticConfig["BaseUri"];
        private static readonly string ApiKey = Startup.StaticConfig["AlphaApiKey"];


        public static Overview GetOverview(string company)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("query");
            request.AddParameter("function", "OVERVIEW");
            request.AddParameter("symbol", company);
            request.AddParameter("apikey", ApiKey);

        }
    }
}

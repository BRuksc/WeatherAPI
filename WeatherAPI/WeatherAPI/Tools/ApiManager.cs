using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class ApiManager : IApiClient<HttpClient>
    {
        public HttpClient ApiClient { get; set; } = new HttpClient();

        public ApiManager(double latitude, double longitude)
        {
            var address = "https://api.open-meteo.com/v1/forecast?latitude=" + latitude.ToString() + 
                "&longitude=" + longitude.ToString() + "&hourly=temperature_2m";
            InitializeClient(address, "application/json");
        }

        public void InitializeClient(string address, string mediaType)
        {
            ApiClient.BaseAddress = new Uri(address);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
        }
    }
}

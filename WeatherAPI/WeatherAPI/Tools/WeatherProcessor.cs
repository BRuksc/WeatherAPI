using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class WeatherProcessor
    {
        public async Task<WeatherModel?> LoadWeatherAsync(string path, HttpClient client)
        {
            WeatherModel? weatherModel = null;
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
                weatherModel = await response.Content.ReadAsAsync<WeatherModel>();

            else throw new Exception(response.ReasonPhrase);

            return weatherModel;
        }
    }
}

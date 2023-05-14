using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public struct WeatherModel
    {
        public double Elevation { get; set; }
        public double Generationtime_ms { get; set; }
        public string Timezone { get; set; }
        public double Temperature { get; set; }
        public double Windspeed { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public WeatherModel(double elevation, double generationtime_ms, string timezone,
            double temperature, double windspeed, string city, string country)
        {
            Elevation = elevation;
            Generationtime_ms = generationtime_ms;
            Timezone = timezone;
            Temperature = temperature;
            Windspeed = windspeed;
            City = city;
            Country = country;
        }
    }
}

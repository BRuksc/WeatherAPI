using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace WeatherAPI.MVVM.Models
{
    internal class MainModel
    {
        internal ApiManager ApiHelper { get; set; }

        public MainModel() 
        { 
            ApiHelper = new ApiManager();
        }
    }
}

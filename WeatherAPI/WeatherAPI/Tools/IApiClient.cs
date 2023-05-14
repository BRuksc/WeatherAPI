using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public interface IApiClient<T>
    {
        T ApiClient { get; set; }
        public void InitializeClient(string address, string mediaType);
    }
}

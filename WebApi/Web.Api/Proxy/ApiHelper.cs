using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public static class ApiHelper
    {
        public static HttpClient ClientApi { get; set; }

        public static void InitializeClient()
        {
            ClientApi = new HttpClient();
            ClientApi.DefaultRequestHeaders.Accept.Clear();
            ClientApi.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Runtime.CompilerServices;

namespace ApiConnector
{
    public static class Processor
    {
        private static readonly string APIKey = "c78c9106b4388a75438bd88c61b0f9bf"; 
        public static async Task<ApiData> GetData(double lat, double lon)
        {
            string URL = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=(2)&appid={3}",
                lat.ToString(), lon.ToString(), "daily", APIKey);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(URL)) 
                {
                    if (response.IsSuccessStatusCode)
                    {
                        ApiData result = await response.Content.ReadAsAsync<ApiData>();
                        return result;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
        }
    }
}


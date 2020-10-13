using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ApiConnector
{
    public static class Processor
    {
        private static readonly string baseURL = "https://api.openweathermap.org/data/2.5/onecall?lat=32.0748110575302&lon=32.0748110575302&exclude=daily&appid=c78c9106b4388a75438bd88c61b0f9bf"; //make it maintanable
        public static async Task<ApiData> GetData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL)) 
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


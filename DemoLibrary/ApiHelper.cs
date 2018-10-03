using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace DemoLibrary
{
    public static class ApiHelper
    {
        // create basic needs of an api call

        public static HttpClient ApiClient { get; set; } 

        public static void InitalizeClient()
        {
            ApiClient = new HttpClient();

            //ApiClient.BaseAddress = new Uri("https://xkcd.com");  // xkcd star with https  append info.0.json or 614.json.hwa  leave blank so we can use client for more thant one req

            ApiClient.DefaultRequestHeaders.Accept.Clear();

            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));  // add header that says "give me json" (Not web page )

            //allows us to make calls on the internet  (like a browser)
        }

    }
}

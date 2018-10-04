using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SunProcessor
    {
        // basically a copy and paste from ComicProcessor  
        // if you were doing it right, you'd make this generic <T> and pass in the URL


        //https://sunrise-sunset.org/api
        //https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400&date=today



        //https://api.sunrise-sunset.org/json?lat=44.928226&lng=--93.254294&date=today

        //44.988391
        //-93.450631



        //https://api.sunrise-sunset.org/json?lat=44.928226&lng=--93.254294&date=today

        //44.928226
        //-93.254294


        public static async Task<SunModel> LoadSunInformation()  // make it async so it doesn't lock up.  It might take a while to get the info
        {
            string url = "https://api.sunrise-sunset.org/json?lat=44.928226&lng=-93.254294&date=today";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))                          // open new request and wait for response.
            {
                if (response.IsSuccessStatusCode)                                                                   // if succesful then.
                {
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();                   // tries to map over the data to our model
                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }



            }   // at end it will close out all thing related to this request.


        }











    }
}

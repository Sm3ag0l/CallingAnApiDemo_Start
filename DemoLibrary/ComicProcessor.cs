using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ComicProcessor
    {

        // call to api
       // public int MaxComicNumber { get; set; }


        public static async Task<ComicModel> LoadComic(int comicNumber = 0)  // make it async so it doesn't lock up.  It might take a while to get the info
        {
            string url = "";

            if (comicNumber >0)
            {
                url = $"https://xkcd.com/{ comicNumber }/info.0.json";
            }
            else
            {

                url = $"https://xkcd.com/info.0.json";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))      // open new request and wait for response.
            {
                if (response.IsSuccessStatusCode)                                               // if succesful then.
                {
                                                                                                // read the data that comes back
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();        // tries to map over the data to our model

                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                    //return null;
                }



            }   // at end it will close out all thing related to this request.


        }

    }
}

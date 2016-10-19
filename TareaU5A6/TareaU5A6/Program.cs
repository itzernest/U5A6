using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace TareaU5A6
{
    class Program
    {
        static void Main(string[] args)
        {

            GetRequest("https://api.flickr.com/services/rest/?method=flickr.photos.getRecent&api_key=87a8d80090089f78e4839c34f1029e87&format=json&nojsoncallback=1");


            Console.ReadKey();
        }
        async static void GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync("https://api.flickr.com/services/rest/?method=flickr.photos.getRecent&api_key=87a8d80090089f78e4839c34f1029e87&format=json&nojsoncallback=1"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        Console.WriteLine(mycontent);

                    }

                }

            }
        }
    }
}


using djab.yts.proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace djab.yts.proxy.Utils
{
    public static class djabHttpClient
    {
        public static HttpClient client = new HttpClient
        {
            BaseAddress = new Uri(Startup.Configuration["BaseUri"])
        };

        public static async Task<T> GetResponse<T>(string path)
        {
            T toReturn = default(T);

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                toReturn = await response.Content.ReadAsAsync<T>();
            }

            return toReturn;
        }
    }
}

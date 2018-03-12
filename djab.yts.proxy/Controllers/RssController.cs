using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using djab.yts.proxy.Models;
using djab.yts.proxy.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace djab.yts.proxy.Controllers
{
    [Route("api/rss")]
    public class RssController : Controller
    {
        [Route("{page:int=1}/{quality?}")]
        [HttpGet]
        public async Task<Rss> Get(int page, string quality = "720p")
        {
            YtsQuality parsedQuality = Enum<YtsQuality>.TryParseByDescription(quality);

            Rss rss = new Rss();

            YtsResponse<YtsMovies> response = await djabHttpClient.GetResponse<YtsResponse<YtsMovies>>($"/api/v2/list_movies.json?quality={parsedQuality.GetDescription()}&page={page}&sort_by=date_added");

            foreach (var item in response.data.movies)
            {
                var itemToAdd = new Item
                {
                    Title = item.title,
                    Link2 = item.url,
                    Guid = item.url,
                    PubDate = item.date_uploaded,
                    Enclosure = new Enclosure(item.torrents.FirstOrDefault(row => row.quality == parsedQuality.GetDescription()).url)
                };

                rss.Channel.Items.Add(itemToAdd);
            }

            return rss;
        }
    }
}
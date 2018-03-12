using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace djab.yts.proxy.Models
{
    public class YtsMovie
    {
        public string url { get; set; }
        public string title { get; set; }
        public List<YtsTorrent> torrents { get; set; }
        public string date_uploaded { get; set; }

        public YtsMovie()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace djab.yts.proxy.Models
{
    public class YtsMovies
    {
        public int movie_count { get; set; }
        public int limit { get; set; }
        public int page_number { get; set; }
        public List<YtsMovie> movies { get; set; }

        public YtsMovies()
        {
            movies = new List<YtsMovie>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace djab.yts.proxy.Models
{
    public class YtsResponse<T>
    {
        public string status { get; set; }
        public string status_message { get; set; }
        public T data { get; set; }

        public YtsResponse()
        {

        }
    }
}

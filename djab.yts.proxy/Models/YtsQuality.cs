using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace djab.yts.proxy.Models
{
    public enum YtsQuality
    {
        [Description("720p")]
        Low,
        [Description("1080p")]
        High,
        [Description("3D")]
        TreeD
    }
}

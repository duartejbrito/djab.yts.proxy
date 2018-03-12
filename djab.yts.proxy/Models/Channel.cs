using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace djab.yts.proxy.Models
{
    [XmlRoot(ElementName = "channel")]
    public class Channel
    {
        [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
        public Link Link { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "link")]
        public string Link2 { get; set; }
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
        [XmlElement(ElementName = "lastBuildDate")]
        public string LastBuildDate { get; set; }
        [XmlElement(ElementName = "item")]
        public List<Item> Items { get; set; }

        public Channel()
        {
            Link = new Link();
            Title = "YTS RSS";
            Description = "Most popular Torrents in the smallest file size RSS Feed";
            Link2 = "https://yts.am/";
            Language = "en-us";
            LastBuildDate = DateTime.Now.ToString();
            Items = new List<Item>();
        }
    }
}

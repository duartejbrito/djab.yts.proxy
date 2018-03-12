using System.Xml.Serialization;

namespace djab.yts.proxy.Models
{
    [XmlRoot(ElementName = "enclosure")]
    public class Enclosure
    {
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "length")]
        public string Length { get; set; }

        public Enclosure()
        {
            Type = "application/x-bittorrent";
            Length = "10000";
        }

        public Enclosure(string url)
            : this()
        {
            Url = url;
        }
    }
}

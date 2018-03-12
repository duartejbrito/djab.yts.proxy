using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace djab.yts.proxy.Models
{
    [XmlRoot(ElementName = "rss")]
    public class Rss
    {
        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "dc", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Dc { get; set; }
        [XmlAttribute(AttributeName = "content", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Content { get; set; }
        [XmlAttribute(AttributeName = "atom", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Atom { get; set; }

        public Rss()
        {
            Version = "2.0";
            Dc = "http://purl.org/dc/elements/1.1/";
            Content = "http://purl.org/rss/1.0/modules/content/";
            Atom = "http://www.w3.org/2005/Atom";
            Channel = new Channel();
        }
    }
}

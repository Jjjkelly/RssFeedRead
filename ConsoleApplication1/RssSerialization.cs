using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
namespace RsstoJson
{
    public class RssSerialization
    {
     
        public static RssItems Items = new RssItems();     

        public static void ParseRssFile()
        {
           RssFeedSetup.rssXmlDoc.Load("http://feeds.bbci.co.uk/news/scotland/rss.xml?edition=uk");

            XmlNodeList rssNodes = RssFeedSetup.rssXmlDoc.SelectNodes("rss/channel/item");

            DirectoryScan.createDataString();                                 

            foreach (XmlNode rssNode in rssNodes)
            {
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
               string titles = JsonConvert.SerializeObject(rssSubNode, Newtonsoft.Json.Formatting.Indented);               
                
                rssSubNode = rssNode.SelectSingleNode("link");
                string links = JsonConvert.SerializeObject(rssSubNode, Newtonsoft.Json.Formatting.Indented);
          
                rssSubNode = rssNode.SelectSingleNode("description");
                string descriptions = JsonConvert.SerializeObject(rssSubNode, Newtonsoft.Json.Formatting.Indented);
        
                rssSubNode = rssNode.SelectSingleNode("pubDate");
                string pubDates = JsonConvert.SerializeObject(rssSubNode, Newtonsoft.Json.Formatting.Indented);

                if (!RssFeedSetup.FileRead.Contains(titles) && (DateTime.Parse(pubDates.Substring(17,16)) == DateTime.Today))
                {
                    Items.AddItem(titles, links, descriptions, pubDates);
                }                
            }
                 
        }
       
    }
}

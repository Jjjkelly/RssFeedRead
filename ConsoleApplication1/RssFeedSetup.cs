using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RsstoJson
{
   public class RssFeedSetup
    {

        public static string FeedsFolder = "feeds";
        public static string RssFeed = "feeds/Rss.Json";
        public static string FileRead = "";

       public static XmlDocument rssXmlDoc = new XmlDocument();
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RsstoJson
{
   public class RssItems
    
    {
        public void AddItem(string title, string link, string description, string pubDate)
        {
            items.Add(title + link + description + pubDate);

        }

        public List<string> items = new List<string>();
    }
}

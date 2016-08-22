using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RsstoJson
{
   public class WriteToJson
    {
      public static void AddToJson()
        {
            foreach (string element in RssSerialization.Items.items)
            {
                Console.WriteLine(element);
                File.AppendAllText(RssFeedSetup.RssFeed, element);
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace RsstoJson
{
    
               
    class DirectoryScan
    {   

        public static void createDataString()
        {
     
            if (!Directory.Exists(RssFeedSetup.FeedsFolder))
            {
                Directory.CreateDirectory(RssFeedSetup.FeedsFolder);
            }

            Array files = Directory.GetFiles(RssFeedSetup.FeedsFolder);

            if (!File.Exists(RssFeedSetup.RssFeed))
            {
                File.Create(RssFeedSetup.RssFeed).Close();
            }


            foreach (string file in files)
            {
                RssFeedSetup.FileRead += File.ReadAllText(file);
            }

        }

    }
}

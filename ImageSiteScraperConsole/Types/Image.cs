using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSiteScraperConsole.Types
{
    public class Image
    {
        public string ImageUrl { get; set; }
        public List<string> ExistsOnUrlList { get; set; }
        public Image(string imageUrl, List<string> existsOnUrlList) { 
            ImageUrl = imageUrl;
            ExistsOnUrlList = existsOnUrlList;
        }
    }
}

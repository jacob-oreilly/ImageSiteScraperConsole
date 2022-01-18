using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSiteScraperConsole.Types
{
    public class UserInput
    {
        public string RootUrl { get; set; }
        public UserInput(string rootUrl)
        {
            RootUrl = rootUrl;
        }
    }
}

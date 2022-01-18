using ImageSiteScraperConsole.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSiteScraperConsole.Helpers
{
    public class UserInputHelper
    {
        public UserInput GetUserInput(string rootUrl) {
            UserInput newUserInput = new UserInput(rootUrl);
            return newUserInput;
        }
    }
}

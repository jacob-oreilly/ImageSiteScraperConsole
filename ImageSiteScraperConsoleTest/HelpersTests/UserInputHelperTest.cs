using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ImageSiteScraperConsole.Helpers;
using ImageSiteScraperConsole.Types;
using System.Runtime;
using Newtonsoft.Json;

namespace ImageSiteScraperConsoleTest.HelpersTests
{
    public class UserInputHelperTest
    {
        [Fact]
        public void GetUserInputTest() {
            var expect = JsonConvert.SerializeObject(new UserInput("https://google.com"));
            var actual = JsonConvert.SerializeObject(new UserInputHelper().GetUserInput("https://google.com"));
            Assert.Equal(expect, actual);
        }
    }
}

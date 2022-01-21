using System;
using System.Collections.Generic;
using System.Text;
using ImageSiteScraperConsole.Helpers;
using Xunit;

namespace ImageSiteScraperConsoleTest.HelpersTests
{
    public class ScraperHelpersTest
    {
        [Fact]
        public void CallUrlTest() {
            var expected = "";
            var actual = ScraperHelper.CallUrl();
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void GetHrefTagsTest() {
            var expected = "";
            var actual = ScraperHelper.GetHrefTags("", "", "");
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void GetImageTagsTest() {
            var expected = "";
            var actual = ScraperHelper.GetImageTags("", "");
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void CrawlSiteTest() {
        //    var expected = "";
        //    var actual = ScraperHelper.CrawlSite(new HashSet<string>(), "", 0, 0, "");
        //    Assert.Equal(expected, actual);
        //}
    }
}

using System;
using Xunit;
using ImageSiteScraperConsole.Helpers;

namespace ImageSiteScraperConsoleTest.HelpersTests
{
    public class HelloWorldTests
    {
        [Fact]
        public void HelloWorldTest()
        {
            var expected = "Hello World";
            var actual = new HelloWorld().PrintHelloWorld();
            Assert.Equal(expected, actual);
        }
    }
}

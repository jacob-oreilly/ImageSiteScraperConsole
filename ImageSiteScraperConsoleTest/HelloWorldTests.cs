using System;
using Xunit;
using ImageSiteScraperConsole;

namespace ImageSiteScraperConsoleTest
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

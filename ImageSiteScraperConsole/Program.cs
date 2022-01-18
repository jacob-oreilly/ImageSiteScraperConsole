using ImageSiteScraperConsole.Types;
using System;

namespace ImageSiteScraperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Easy image scraper. Please follow the prompt to scrape the desired website for all locations of all the images on your site.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter the Url of the site you want to Scrape: ");
            UserInput userInput = new UserInput(Console.ReadLine());
            Console.WriteLine(userInput.RootUrl);
        }
    }
}

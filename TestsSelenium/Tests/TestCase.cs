using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class TestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demoqa.com";

            driver.Navigate().GoToUrl("http://google.com");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

            string title= driver.Title;
            int titleLength = driver.Title.Length;

            Console.WriteLine("Title of this page is" + title);
            Console.WriteLine("Length of this title is" + titleLength);

            string pageURL = driver.Url;
            int URLLength = pageURL.Length;

            Console.WriteLine("URL of the website is" + pageURL);
            Console.WriteLine("URL Length of the website is" + URLLength);


           
        }
    }
}

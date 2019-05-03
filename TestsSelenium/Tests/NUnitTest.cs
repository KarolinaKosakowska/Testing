using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Tests
{
    class NUnitTest
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void TestApp()
        {
            driver.Url = "http://www.demoqa.com";
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}

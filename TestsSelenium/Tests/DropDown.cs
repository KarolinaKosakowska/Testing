using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
    class DropDown
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.com/automation-practice-form";

            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("continents")));
            oSelection.SelectByText("Europe");
            Thread.Sleep(2000);

            IList<IWebElement> oSize = oSelection.Options;
            int iListSize = oSize.Count;

            for(int i=0;i<iListSize;i++)
            {
                string sValue = oSelection.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the select item is" + sValue);

                if(sValue.Equals("Africa"))
                {
                    oSelection.SelectByIndex(i);
                    break;
                }
            }
        }
    }
}

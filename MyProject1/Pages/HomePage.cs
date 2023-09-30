using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyProject1.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            try { 
            //Navigate to time & material module
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
        }
            catch(Exception exception)
            { 
            Assert.Fail("TurnUp Portal Homepage not displayed", exception.Message);
            }
            IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialOption.Click();
        }
    }
}

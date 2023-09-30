using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using MyProject1.Utilities;

namespace MyProject1.Pages
{
    public class TimeMaterialpage
    {
        public void CreateNewTimeRecord(IWebDriver driver)
        {
            //WebDriverWait webDriverWait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            //webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/*[@id=\"container\"]/p/a")));
            Wait.waitToBeClickable(driver, "Xpath" ,"//*[@id=\"container\"]/p/a",5);

            //Verify Create New Time record
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //Select Typcode Time from the dropdown list
            IWebElement mainTypeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            mainTypeCodeDropDown.Click();

            //*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]
            IWebElement timeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeDropdown.Click();

            //Enter code in the Code field

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Testing Programme1");

            //Enter Description in the description field
            Wait.waitToBeVisible(driver, "Id", "Description", 7);
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Study Materials1");

            //Enter price in the Price field
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.SendKeys("151");

            //CLick on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);
            //Check if a new Time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[5]/td[1]
            if (newCode.Text == "Testing Programme1")
            {
                Console.WriteLine("New record has been created successfully");
            }
            else
            {
                Console.WriteLine(" New record has not created successfully");
            }
        }
    }
}
        
      

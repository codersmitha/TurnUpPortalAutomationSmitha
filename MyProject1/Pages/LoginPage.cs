using MyProject1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            
            //Launch TurnUp portal and navigate to the login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

            //Identify username textbox and input valid user name
            Wait.waitToBeVisible(driver, "Id", "UserName", 7);
            IWebElement UsernameTextBox = driver.FindElement(By.Id("UserName"));
            UsernameTextBox.SendKeys("hari");
            
            //Identify password textbox and input valid password
            IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));
            
            PasswordTextBox.SendKeys("123123");
            //Identify login button and click on login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            LoginButton.Click();
        }
    }
}

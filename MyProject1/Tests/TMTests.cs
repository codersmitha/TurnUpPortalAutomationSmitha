using MyProject1.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyProject1.Utilities;

namespace MyProject1.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            //open the chrome browser
            driver = new ChromeDriver();

            //Login page Object initialisation and definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(driver);

            //driver.Manage().Timeouts.ImplicitWait = TimeSpan.FromSeconds(5);

            //Homepage Object initialisation and definition
            HomePage homePageobj = new HomePage();
            homePageobj.GoToTMPage(driver);
        }
        [Test]
        public void TestCreateTimeRecord()
        {
            //TimeMaterial page Object initialisation and definition
            TimeMaterialpage timeMaterialpageobj = new TimeMaterialpage();
            timeMaterialpageobj.CreateNewTimeRecord(driver);
        }
        [Test]
        public void TestEditTimeRecord() 
        {
            
        }

        [Test]
        public void TestDeleteTimeRecord()
        {

        }
        [TearDown]
        public void CLoseTestRun()
        {
        driver.Quit();
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

        
        
    }
}

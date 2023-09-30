// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MyProject1.Pages;

class Program
{
    private static void Main(string[] args)
    {
        //open the chrome browser
        IWebDriver driver = new ChromeDriver();

        //Login page Object initialisation and definition
        LoginPage loginPageobj = new LoginPage();
        loginPageobj.LoginActions(driver);

        //Homepage Object initialisation and definition
        HomePage homePageobj = new HomePage();
        homePageobj.GoToTMPage(driver);
        //TimeMaterial page Object initialisation and definition
        TimeMaterialpage timeMaterialpageobj = new TimeMaterialpage();
        timeMaterialpageobj.CreateNewTimeRecord(driver);

    }
}


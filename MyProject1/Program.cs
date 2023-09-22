// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

//open the chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//Launch TurnUp portal and navigate to the login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
//Identify username textbox and input valid user name
IWebElement UsernameTextBox = driver.FindElement(By.Id("UserName"));
UsernameTextBox.SendKeys("hari");
//Identify password textbox and input valid password
IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));
PasswordTextBox.SendKeys("123123");
//Identify login button and click on login button
IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
LoginButton.Click();
//Check if the user has logged in successfully
IWebElement HelloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (HelloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("Üser hasn't logged in.");
}


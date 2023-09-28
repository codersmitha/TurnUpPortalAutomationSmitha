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
Thread.Sleep(5000);
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
//Test case-Create a New Time record

//Navigate to Time & Material page
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();
IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeMaterialOption.Click();
//Verify Create New Time record
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();
//Select Typcode Time from the dropdown list
IWebElement mainTypeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
mainTypeCodeDropDown.Click();
//*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]
IWebElement timeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeDropdown.Click();
//*[@id="TypeCode_option_selected"]
//*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]
//*[@id="TypeCode_listbox"]/li[2]

//Enter code in the Code field

IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("Testing Programme1");
//Enter Description in the description field
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



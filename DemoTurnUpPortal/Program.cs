using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

                               //Open the chrome browser and maximize 

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

                              //Launch chrome browser, enter the url and navigate to login page(http://horse.industryconnect.io/)

driver.Navigate().GoToUrl("http://horse.industryconnect.io/");


                               //Enter the user name on the username text box

IWebElement nameTextbox = driver.FindElement(By.Id("UserName"));
nameTextbox.SendKeys("hari");


                               //Enter the password on the password text box

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");


                                //Identify the LoginButton and click on login

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();


                               //User logged in sucessfully or not

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in Successfully");
}
else
{ 

   Console.WriteLine("User not logged in successfully");
}

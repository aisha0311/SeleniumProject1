using AishaSelenium_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AishaSelenium_Task2.Page
{
    internal class LoginTestCases //class
    {
        private IWebDriver driver; // constructor

        public LoginTestCases(IWebDriver driver)
        {
            this.driver = driver;
        }
        

        public void LoginPage() //method
        {
            //USER NAME
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");
            //PASSWORD
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //explicit wait
            Async.WaitForWebElementClikable(driver, "//input[@value='Log in']", 1, "XPath");

            //LOGIN
            IWebElement login = driver.FindElement(By.XPath("//input[@value='Log in']"));
            login.Click();
        }


       


    }
}
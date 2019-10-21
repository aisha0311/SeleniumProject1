using AishaSelenium_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AishaSelenium_Task2.Page
{
    internal class LoginTestPage //class
    {
        private IWebDriver driver; // constructor

        public LoginTestPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        

        public void LoginPage() //method
        {
            //populate/create collection during runtime
            //excel sheet (external data)       ("path of excel sheet","sheet name")
            ExcelUtility.PopulateInCollection(@"C:\Users\shaik\source\repos\AishaSelenium_Task2\AishaSelenium_Task2\TestData\project_inputs.xlsx", "data info");

            //USER NAME
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys(ExcelUtility.ReadData(2,"user name")); //user name = hari

            //PASSWORD
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys(ExcelUtility.ReadData(2, "password")); // password = 123123
                                       // readData(row number,coloum name)

            //explicit wait
            Async.WaitForWebElementClikable(driver, "//input[@value='Log in']", 1, "XPath");

            //LOGIN
            IWebElement login = driver.FindElement(By.XPath("//input[@value='Log in']"));
            login.Click();
        }


       


    }
}
using NUnit.Framework;
using OpenQA.Selenium;

namespace AishaSelenium_Task2.Page
{
    internal class HomeTestCases //class
    {
        private IWebDriver driver; //constructor

        public HomeTestCases(IWebDriver driver) 
        {
            this.driver = driver;
        }
      
        internal void HomeTestCases1() //method
        {
            //ADMINISTRATION
            IWebElement administration = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));
            administration.Click();
            //TIME AND MANAGEMENT
            var timeMaterials = driver.FindElement(By.LinkText("Time & Materials"));
            timeMaterials.Click();

        }
    }
}
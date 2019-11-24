using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AishaSelenium_Task2.Utilities
{
    class Async
    {
        public static IWebDriver Driver { get; private set; }

        //custom method to handle wait for a webelement to be visible
        public static void WaitForWebElementVisibility(IWebDriver driver, string domvalue, int seconds, string locator )
        {
            try
            {
                if (locator == "Xpath")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(domvalue)));
                }
                if (locator == "id")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(domvalue)));
                }
                if (locator == "ClassName")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(domvalue)));
                }
                if (locator == "LinkText")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(domvalue)));
                }
                if (locator == "Name")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(domvalue)));
                }
            }
            catch(Exception msg)
            { 
                Assert.Fail(msg.Message);
            }
        }

        //custom method to handle wait for a 'webelement to be  exist'
        public static void WaitForWebElementExists(IWebDriver driver, string domvalue, int seconds, string locator)
        {
            try
            {
                if (locator == "Xpath")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(domvalue)));
                }
                if (locator == "id")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(domvalue)));
                }
                if (locator == "ClassName")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName(domvalue)));
                }
                if (locator == "LinkText")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(domvalue)));
                }
                if (locator == "Name")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(domvalue)));
                }
            }
            catch (Exception msg)
            {
                Assert.Fail(msg.Message);
            }
        }

        //custom method to handle wait for a 'webelement to be  clickable'
        public static void WaitForWebElementClikable(IWebDriver driver, string domvalue, int seconds, string locator)
        {
            try
            {
                if (locator == "Xpath")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(domvalue)));
                }
                if (locator == "id")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(domvalue)));
                }
                if (locator == "ClassName")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(domvalue)));
                }
                if (locator == "LinkText")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(domvalue)));
                }
                if (locator == "Name")
                {
                    var Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(domvalue)));
                }
            }
            catch (Exception msg)
            {
                Assert.Fail(msg.Message);
            }
        }


    }
}

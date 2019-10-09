using AishaSelenium_Task2.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AishaSelenium_Task2.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialSteps
    {
        private ChromeDriver driver;

        [Given(@"I have logged into Turn Up portal")]
        public void GivenIHaveLoggedIntoTurnUpPortal()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestCases login = new LoginTestCases(driver); //creating an object of 'logintestcases'
            login.LoginPage();
        }

        [Given(@"I have navigated to Time and Material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
        {
            //ADMINISTRATION
            IWebElement administration = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));
            administration.Click();
            //TIME AND MANAGEMENT
            var timeMaterials = driver.FindElement(By.LinkText("Time & Materials"));
            timeMaterials.Click();
        }

        [Then(@"I should be able to create a material record successfully")]
        public void ThenIShouldBeAbleToCreateAMaterialRecordSuccessfully()
        {
            //CREATENEW

            var createNewButton = driver.FindElement(By.LinkText("Create New"));
            createNewButton.Click();

            // DROPDOWN

            IWebElement dropdown = driver.FindElement(By.XPath("(//span[@unselectable='on'][contains(.,'select')])[4]"));
            dropdown.Click();
            driver.FindElement(By.XPath("//li[@tabindex='-1'][contains(.,'Time')]")).Click();

            //CODETEXT

            var codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("aisha shaik");

            //DESCTEXT

            var descTextbox = driver.FindElement(By.Id("Description"));
            descTextbox.SendKeys("test description");

            //PRICETEXT

            var pricePerUnit = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            pricePerUnit.SendKeys("100");

            //SAVE

            IWebElement saveButton = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            saveButton.Click();
        }
    }
}
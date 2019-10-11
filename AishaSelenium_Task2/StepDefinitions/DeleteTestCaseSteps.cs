using AishaSelenium_Task2.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AishaSelenium_Task2.StepDefinitions
{
    [Binding]
    public class DeleteTestCaseSteps
    {
        private ChromeDriver driver;

        [Given(@"I have logged into Turn-up portal")]
        public void GivenIHaveLoggedIntoTurn_UpPortal()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestCases login = new LoginTestCases(driver); //creating an object of 'logintestcases'
            login.LoginPage();
        }
        
        [Given(@"I have navigated to Time&Material page")]
        public void GivenIHaveNavigatedToTimeMaterialPage()
        {
            //ADMINISTRATION
            IWebElement administration = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));
            administration.Click();
            //TIME AND MANAGEMENT
            var timeMaterials = driver.FindElement(By.LinkText("Time & Materials"));
            timeMaterials.Click();
        }
        
        [When(@"I click on the delete button on the grid")]
        public void WhenIClickOnTheDeleteButtonOnTheGrid()
        {
            // delete test cases
            DeleteTestCases delete = new DeleteTestCases(driver);
            delete.DeleteTimeAndMaterials();

           
        }
        
        [Then(@"the input values should be deleted")]
        public void ThenTheInputValuesShouldBeDeleted()
        {
            Validations val = new Validations(driver);
            val.ValidateTimeMaterial("112233", false, true);

            bool isfound = val.ValidateTimeMaterial("112233", false, false);
            Assert.Equals(false, isfound);
        }
    }
}

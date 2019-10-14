using AishaSelenium_Task2.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AishaSelenium_Task2.StepDefinition
{
    [Binding]
    public class CreateTimeAndMaterialSteps
    {
        IWebDriver driver;


        [Given(@"I have logged into Turn Up portal")]
        public void GivenIHaveLoggedIntoTurnUpPortal()
        {


            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestPage login = new LoginTestPage(driver); //creating an object of 'logintestcases'
            login.LoginPage();
        }

        [Given(@"I have navigated to Time and Material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
        {
            //home test cases           
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
            Thread.Sleep(2000);
        }

        [Then(@"I should be able to create a material record successfully")]
        public void ThenIShouldBeAbleToCreateAMaterialRecordSuccessfully()
        {
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
            // creat new cases
            CreatTMTestCases create = new CreatTMTestCases(driver);
            create.CreateTimeAndMaterials();

            Validations val = new Validations(driver);
            bool isCreated = val.ValidateTimeMaterial("aisha shaik", false, false);
            Assert.Equals(true, isCreated);

        }
    }
}


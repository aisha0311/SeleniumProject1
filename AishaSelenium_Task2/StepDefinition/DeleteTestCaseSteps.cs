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
    public class DeleteTimeAndMaterialSteps
    {

        IWebDriver driver;
        [Given(@"I have logged into Turn-up portal")]
        public void GivenIHaveLoggedIntoTurn_UpPortal()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestPage login = new LoginTestPage(driver); //creating an object of 'logintestcases'
            login.LoginPage();
        }



        [Given(@"I have navigated to Time&Material page")]
        public void GivenIHaveNavigatedToTimeMaterialPage()
        {
            //home test cases           
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
            Thread.Sleep(2000);
        }

        [Then(@"I click on the delete button on the grid")]
        public void WhenIClickOnTheDeleteButtonOnTheGrid()
        {

            // delete test cases
            DeleteTestPage delete = new DeleteTestPage(driver);
            delete.DeleteTimeAndMaterials();
        }
    }
       
}

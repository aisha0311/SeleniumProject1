using AishaSelenium_Task2.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AishaSelenium_Task2
{
    [Binding]
    public class TestDeleteCaseSteps
    {
        IWebDriver driver;
        [Given(@"I have to login time and material portal and click on delete button\.")]
        public void GivenIHaveToLoginTimeAndMaterialPortalAndClickOnDeleteButton_()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestPage login = new LoginTestPage(driver); //creating an object of 'logintestcases'
            login.LoginPage();

            //home test cases           
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();

        }

        [Then(@"the values should be deleted\.")]
        public void ThenTheValuesShouldBeDeleted_()
        {
                // delete test cases
                DeleteTestPage delete = new DeleteTestPage(driver);
                delete.DeleteTimeAndMaterials();
            driver.Quit();


        }
    }
}

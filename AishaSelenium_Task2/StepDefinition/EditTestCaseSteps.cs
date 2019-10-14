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
    public class EditTimeAndMaterialSteps
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
        

        [Given(@"I have navigated to TimeandMaterial page")]
        public void GivenIHaveNavigatedToTimeandMaterialPage()
        {
            //home test cases           
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
            Thread.Sleep(2000);
        }
    
    
        
        [When(@"I clicked on edit then it should edit the data")]
        public void WhenIClickedOnEditThenItShouldEditTheData()
        { 
        {
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
            //   edit test cases
            EditTestPage edit = new EditTestPage(driver);

            Validations val = new Validations(driver);
            string code = "aisha shaik";

            bool isFound = val.ValidateTimeMaterial(code, true, false);
            if (isFound)
            {
                edit.EditTimeAndMaterials();

                bool isEdited = val.ValidateTimeMaterial("112233", false, false);

                Assert.Equals(true, isEdited);
                Assert.Pass("Successfully edited the row.");
            }
            else
            {
                Assert.Fail($"Code {code} not found.");
            }
        }

    }

    [Then(@"i should be able to save the Edited data")]
        public void ThenIShouldBeAbleToSaveTheEditedData()
        {

        // EDITSAVE
        IWebElement editSave = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
        editSave.Click();

         }
}
}


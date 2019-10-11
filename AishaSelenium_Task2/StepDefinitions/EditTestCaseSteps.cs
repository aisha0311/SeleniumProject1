using AishaSelenium_Task2.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AishaSelenium_Task2.StepDefinitions
{
    [Binding]
    public class EditTestCaseSteps
    {
        private ChromeDriver driver;

        [Given(@"I have logged into turn-up portal")]
        public void GivenIHaveLoggedIntoTurn_UpPortal()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestCases login = new LoginTestCases(driver); //creating an object of 'logintestcases'
            login.LoginPage();
        }
        
        [Given(@"I have navigated to TimeandMaterial page")]
        public void GivenIHaveNavigatedToTimeandMaterialPage()
        {
            //ADMINISTRATION
            IWebElement administration = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));
            administration.Click();
            //TIME AND MANAGEMENT
            var timeMaterials = driver.FindElement(By.LinkText("Time & Materials"));
            timeMaterials.Click();
        }
        
        [When(@"I clicked on edit then it should edit the data")]
        public void WhenIClickedOnEditThenItShouldEditTheData()
        {
            //   edit test cases
            EditTestCases edit = new EditTestCases(driver);

            Validations val = new Validations(driver);

            val.ValidateTimeMaterial("aisha shaik", true, false);

            edit.EditTimeAndMaterials();

            bool isEdited = val.ValidateTimeMaterial("112233", false, false);

            Assert.Equals(true, isEdited);
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

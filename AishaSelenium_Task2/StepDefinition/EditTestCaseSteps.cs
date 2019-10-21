using AishaSelenium_Task2.Page;
using AishaSelenium_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AishaSelenium_Task2.StepDefinition
{
    [Binding]
    public class EditTestCaseSteps
    {
        IWebDriver driver;
        [Given(@"I have to login time and material portal and edit the values and click on edit button\.")]
        public void GivenIHaveToLoginTimeAndMaterialPortalAndEditTheValuesAndClickOnEditButton_()
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
            

       [Then(@"the values should be edited\.")]
        public void ThenTheValuesShouldBeEdited_()
        {
            //   edit test cases
            EditTestPage edit = new EditTestPage(driver);

            Validations val = new Validations(driver);
            string code = ExcelUtility.ReadData(2, "Validate"); //aisha shaik-validate

            bool isFound = val.ValidateTimeMaterial(code, true, false);
            if (isFound)
            {
                edit.EditTimeAndMaterials();

                bool isEdited = val.ValidateTimeMaterial(ExcelUtility.ReadData(2, "editValidate"), false, false); //112233 = edit validate 

                Assert.AreEqual(true, isEdited);
                Assert.Pass("Successfully edited the row.");
            }
            else
            {
                Assert.Fail($"Code {code} not found.");
            }
        

        IWebElement editSave = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            editSave.Click();
            driver.Quit();
        }
    }
}

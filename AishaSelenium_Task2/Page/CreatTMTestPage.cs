using AishaSelenium_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AishaSelenium_Task2.Page
{
    internal class CreatTMTestCases //class
    {
        private IWebDriver driver; //constructor


        public CreatTMTestCases(IWebDriver driver)
        {
            this.driver = driver;
        }

  
        public void CreateTimeAndMaterials() //method
        {
            ExcelUtility.PopulateInCollection(@"C:\Users\shaik\source\repos\AishaSelenium_Task2\AishaSelenium_Task2\TestData\project_inputs.xlsx", "data info");
            //CREATENEW

            var createNewButton = driver.FindElement(By.LinkText("Create New"));
            createNewButton.Click();

            // DROPDOWN

            IWebElement dropdown = driver.FindElement(By.XPath("(//span[@unselectable='on'][contains(.,'select')])[4]"));
            dropdown.Click();
            driver.FindElement(By.XPath("//li[@tabindex='-1'][contains(.,'Time')]")).Click();

            //CODETEXT

            var codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys(ExcelUtility.ReadData(2, "code text")); //code text = aisha shaik

            //DESCTEXT

            var descTextbox = driver.FindElement(By.Id("Description"));
            descTextbox.SendKeys(ExcelUtility.ReadData(2, "desc text")); //desc text = test description

            //PRICETEXT

            var pricePerUnit = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            pricePerUnit.SendKeys(ExcelUtility.ReadData(2, "price text")); // price text=100

            //SAVE

            //Explicit wait
            Async.WaitForWebElementVisibility(driver, "//input[contains(@id,'SaveButton')]", 2, "XPath");

           var saveButton = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
           saveButton.Click();

        }
    }
}
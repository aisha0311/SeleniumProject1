using System.Threading;
using AishaSelenium_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AishaSelenium_Task2.Page
{
    internal class EditTestPage //class
    {
        private IWebDriver driver; //constructor

        public EditTestPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

      
        public void EditTimeAndMaterials() //method
        {
            ExcelUtility.PopulateInCollection(@"C:\Users\shaik\source\repos\AishaSelenium_Task2\AishaSelenium_Task2\TestData\project_inputs.xlsx", "data info");
            //EDIT
            // DROPDOWN
            IWebElement editdropdown = driver.FindElement(By.XPath("(//span[@unselectable='on'][contains(.,'select')])[4]"));
            editdropdown.Click();
            driver.FindElement(By.XPath("//li[@tabindex='-1'][contains(.,'Time')]")).Click();

            // EDITCODETEXT
            var editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys(ExcelUtility.ReadData(2, "edit code text")); //edit code text=112233
            //Thread.Sleep(2000);
            //Explicit Wait           
            Async.WaitForWebElementVisibility(driver, "Code", 2, "Id");


            //EDITDESCTEXT
            var editDescTextbox = driver.FindElement(By.Id("Description"));
            editDescTextbox.Clear();
            editDescTextbox.SendKeys(ExcelUtility.ReadData(2, "edit desc text")); //edit desc text = edited test description 
            // Thread.Sleep(2000);
            //Explicit Wait
            //  Async.WaitForWebElement(driver);
            Async.WaitForWebElementVisibility(driver, "Description", 2, "Id");


           // EDITSAVE
            IWebElement editSave = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            editSave.Click();

        }
    }
}
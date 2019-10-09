using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AishaSelenium_Task2.Page
{
    internal class EditTestCases //class
    {
        private IWebDriver driver; //constructor

        public EditTestCases(IWebDriver driver) 
        {
            this.driver = driver;
        }

      
        public void EditTimeAndMaterials() //method
        {

            //EDIT
            // DROPDOWN
            IWebElement editdropdown = driver.FindElement(By.XPath("(//span[@unselectable='on'][contains(.,'select')])[4]"));
            editdropdown.Click();
            driver.FindElement(By.XPath("//li[@tabindex='-1'][contains(.,'Time')]")).Click();

            // EDITCODETEXT
            var editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("112233");
            Thread.Sleep(2000);

            //EDITDESCTEXT
            var editDescTextbox = driver.FindElement(By.Id("Description"));
            editDescTextbox.Clear();
            editDescTextbox.SendKeys("edited test description");
            Thread.Sleep(2000);

            // EDITSAVE
            IWebElement editSave = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            editSave.Click();

        }
    }
}
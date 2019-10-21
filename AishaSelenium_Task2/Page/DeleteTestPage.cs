using AishaSelenium_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AishaSelenium_Task2.Page
{
    internal class DeleteTestPage //class
    {
        private IWebDriver driver; //constructor

        public DeleteTestPage(IWebDriver driver)
        {
            this.driver = driver;
        }

       
        public void DeleteTimeAndMaterials() //method
        {
            ExcelUtility.PopulateInCollection(@"C:\Users\shaik\source\repos\AishaSelenium_Task2\AishaSelenium_Task2\TestData\project_inputs.xlsx", "data info");

            if (true)
                    { 
                string code = ExcelUtility.ReadData(2, "delete"); //delete = 112233
                Console.WriteLine("deleting");                                           // find the row with this code and delete the row

                Validations val = new Validations(driver);

                val.ValidateTimeMaterial(ExcelUtility.ReadData(2, "delete"), false, true); //delete = 112233

                bool isFound = val.ValidateTimeMaterial(ExcelUtility.ReadData(2, "delete"), false, false); //delete = 112233

                Assert.AreEqual(false, isFound);
            }
            else
            {

            }

        
        }
        
    }
}
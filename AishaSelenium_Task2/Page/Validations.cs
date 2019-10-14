using OpenQA.Selenium;
using System.Threading;
using System.Linq;
using NUnit.Framework;

namespace AishaSelenium_Task2.Page
{
    internal class Validations //class
    {
        private IWebDriver driver; //constructor

        public Validations(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        public bool ValidateTimeMaterial(string code, bool needEdit, bool isDelete) //method
        {
            //LASTPAGE()
            Thread.Sleep(2000);//wait for 4 sec

            driver.FindElement(By.XPath("//a[@title='Go to the last page']")).Click();
            bool isFound = false;
            Thread.Sleep(4000);//wait

            while (!isFound)
            {
                // TABLEBODY           
                var tableBody = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody"));

                //TABLEROWS           
                var tableRows = tableBody.FindElements(By.TagName("tr")).ToList();

                if (tableRows.Count <= 0)
                {
                    return isFound;
                }
                //ROW (ITERATING EACH ROW)
                foreach (var row in tableRows)
                {
                    // get the list of columns in the row.

                    var columns = row.FindElements(By.TagName("td")).ToList();
                    //find row of aisha shaik
                    if (columns[0].Text == code)
                    {
                        isFound = true;
                        if (needEdit)
                        {

                            columns[4].FindElement(By.CssSelector("a.k-button.k-button-icontext.k-grid-Edit")).Click();
                        }
                        if (isDelete)
                        {
                            columns[4].FindElement(By.CssSelector("a.k-button.k-button-icontext.k-grid-Delete")).Click();
                            driver.SwitchTo().Alert().Accept();
                        }
                        break;
                    }
                }
                if(!isFound)
                driver.FindElement(By.XPath("//a[@title='Go to the previous page']")).Click();
            }

            return isFound;
        }


    }
}
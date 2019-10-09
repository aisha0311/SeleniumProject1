using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AishaSelenium_Task2.Page
{
    [TestFixture]
    public class TimeAndMaterial
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestCases login = new LoginTestCases(driver); //creating an object of 'logintestcases'
            login.LoginPage();
        }


        [Test]
        public void HomeTest()
        {
            //home test cases           
            HomeTestCases home = new HomeTestCases(driver);
            home.HomeTestCases1();
            Thread.Sleep(2000);
        }

        [Test]
        public void CreatTest()
        {
            // creat new cases
            CreatTMTestCases create = new CreatTMTestCases(driver);
            create.CreateTimeAndMaterials();

            Validations val = new Validations(driver);
            bool isCreated = val.ValidateTimeMaterial("aisha shaik", false, false);
            Assert.Equals(true, isCreated);
        }       

        [Test]
        public void EditTest()
        {
            //   edit test cases
            EditTestCases edit = new EditTestCases(driver);          

            Validations val = new Validations(driver);

            val.ValidateTimeMaterial("aisha shaik", true, false);

            edit.EditTimeAndMaterials();

            bool isEdited = val.ValidateTimeMaterial("112233", false, false);

            Assert.Equals(true, isEdited);
        }

        [Test]
        public void DeleteTest()
        {
            // delete test cases
            DeleteTestCases delete = new DeleteTestCases(driver);
            delete.DeleteTimeAndMaterials();

            Validations val = new Validations(driver);
            val.ValidateTimeMaterial("112233", false, true);

            bool isfound = val.ValidateTimeMaterial("112233", false, false);
            Assert.Equals(false, isfound);
        }
        
        //Console.Read();

        [TearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

    }

}


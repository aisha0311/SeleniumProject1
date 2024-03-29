﻿using AishaSelenium_Task2.Page;
using AishaSelenium_Task2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AishaSelenium_Task2.Test
{


    [TestFixture]
    public class TimeAndMaterial
    {

        IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestPage login = new LoginTestPage(driver); //creating an object of 'logintestcases'
            login.LoginPage();
        }


        [Test]
        public void HomeTest()
        {
            //home test cases           
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
           

        }

        [Test]
        public void CreatTest()
        {
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
            // creat new cases
            CreatTMTestCases create = new CreatTMTestCases(driver);
            create.CreateTimeAndMaterials();

            Validations val = new Validations(driver);
            bool isCreated = val.ValidateTimeMaterial(ExcelUtility.ReadData(2, "Validate"), false, false); //aisha shaik = validate
            Assert.AreEqual(true, isCreated);

        }

        [Test]
        public void EditTest()
        {
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();

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
        }

         [Test]
        public void DeleteTest()
        {
            HomeTestPage home = new HomeTestPage(driver);
            home.HomeTestCases1();
            // delete test cases
            DeleteTestPage delete = new DeleteTestPage(driver);
            delete.DeleteTimeAndMaterials();

        }

        //Console.Read();

        [TearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

    }

}


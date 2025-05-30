using Microsoft.Extensions.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgramme.Pages;
using TAProgramme.Utilities;

namespace TAProgramme.Tests
{

    [TestFixture]


   public class TM_Tests : CommonDriver
    {

        [SetUp]
        public void SetupSteps()
        {
            // Open Chrome Browser
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);
            // Open Chrome browser
            driver = new ChromeDriver();
            ///Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);
            
        }
        [Test]
        public void CreateTime_Test()
        {
            //TM Page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);

        }
        [Test]
        public void EditTime_Test()
        {
            //Edit Time Record
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);

        }
        [Test]
        public void DeleteTime_Test()
        {
            //Delete Time Record
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeRecord(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            // Close the driver and clean up resources after tests are done.
            driver.Quit();
        }


    }
}

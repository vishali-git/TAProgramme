﻿using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgramme.Utilities;

namespace TAProgramme.Pages
{
    public class LoginPage
    {

        
        // Functions that allow users to login TurnUp Portal
        public void LoginActions(IWebDriver driver)
        {
            // Launch TurnUp Portal 

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);



            // Identify username textbox and enter valid username 

            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("UserName")));

            Wait.waitToBeVisible(driver, "Id", "Password", 7);
            // Identify password textbox and enter valid password 

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // Identify login button and click on it 
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
           
        }
    }
}

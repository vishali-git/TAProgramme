using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TAProgramme.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver) 
        {
            //navigate to Time and Material Page 
            IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a/span"));
            adminstrationTab.Click();





            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();


            
            


        }
    }
}

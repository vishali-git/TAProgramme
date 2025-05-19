using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAProgramme.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver) 
        {
            //Click on Create New Button 

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));

            createNewButton.Click();



            // Select Time from dropdown 

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));

            typeCodeDropdown.Click();



            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));

            timeOption.Click();







            //Type code into Code textbox 

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));

            codeTextbox.SendKeys("TA Programme");



            //Type descripton into Descripton textbox 

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));

            descriptionTextbox.SendKeys("This is a Description");



            //Type price into Price textbox 

            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));

            priceTagOverlap.Click();



            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));

            priceTextbox.SendKeys("12");



            //Click on Save button 

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));

            saveButton.Click();

            Thread.Sleep(3000);





            //Check if Time record created succesfully 

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            goToLastPageButton.Click();



            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));





            if (newCode.Text == "TA Programme")

            {

                Console.WriteLine("Time record created successfully!");



            }

            else

            {

                Console.WriteLine("Time record has not created");

            }
        }
        public void EditTimeRecord(IWebDriver driver)
        {
            // Put you edit time record code here
        }
        public void DeleteTimeRecord(IWebDriver driver)
        {
            // Put you delete time record code here

        }


    }
}


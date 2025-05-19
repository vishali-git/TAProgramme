using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TAProgramme.Pages;

public class Program

{
    private static void Main(string[] args)

    {

        Console.WriteLine("Hello, World!");

        //open chrome browser 


        IWebDriver driver = new ChromeDriver();
        

        //Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home Page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

        //TM Page object initialization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);

        //Edit Time Record
        tmPageObj.EditTimeRecord(driver);

        //Delete Time Record
        tmPageObj.DeleteTimeRecord(driver);


    }

}
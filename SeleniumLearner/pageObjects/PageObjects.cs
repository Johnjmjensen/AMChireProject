using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;


namespace pageObjects
{

    class HomePage
     {
        

        public readonly static String test_url = "https://academymortgage.com/";
        public readonly static String allNewsSelector = "#site-main > div.news.module.listing > div > div > a";
        public class MultiBroweserDriver<TWebDriver> where TWebDriver : IWebDriver, new()
        {
            public static void GetAllNewsLink()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                IWebElement AllNewsLink = driver.FindElement(By.CssSelector(allNewsSelector));
            }
        }
        //private static readonly IWebDriver ChromDriver = new ChromeDriver(".");
        //private static readonly IWebDriver Foxdriver = new FirefoxDriver(".");
        //private IWebDriver driver;






    }
    class NewPage
        {
        public readonly static String test_url = "https://academymortgage.com/news/all-news";

    }
    class FindaLoanOfficerPage
    {
        public readonly static String test_url = "https://academymortgage.com/find-a-loan-officer";
        public readonly static String NameFeildSelector = "#Name";
        public readonly static String NameSearchButtonSelector = "#searchBtn";
        public readonly static string ZipSearchField = "#Zip";
        public readonly static string ZipRadiusSelector = "#Radius";
        public readonly static string zipSearchButton = "#searchBtn";
        public class MultiBroweserDriver<TWebDriver> where TWebDriver : IWebDriver, new() //there is a better way to implement this to recycle less code and reference more.
        {
            public static void GetNameField()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                IWebElement NameField = driver.FindElement(By.CssSelector(NameFeildSelector));
            }
            public static void GetNameSearch()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                IWebElement nameSearch = driver.FindElement(By.CssSelector(NameSearchButtonSelector));
            }
            public static void GetZipField()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                IWebElement ZipField = driver.FindElement(By.CssSelector(ZipSearchField));
            }
            public static void GetZipRadius()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                IWebElement ZipRadius = driver.FindElement(By.CssSelector(ZipRadiusSelector));
            }
            public static void GetZipSearch()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                IWebElement ZipSearch = driver.FindElement(By.CssSelector(zipSearchButton));
            }
            //TODO implement loop to check name class for Matt Keyes to assert against. Repeat for nmls-desktop class for other assert.

        }
    }
}
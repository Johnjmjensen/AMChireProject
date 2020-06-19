using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;


//TODO resolve issues around inability to run tests.
namespace TestActions
{
    class TestActions
    {


        //[TestFixture(typeof(FirefoxDriver))]
        //[TestFixture(typeof(ChromeDriver))]

        public class MultiBroweserDriver<TWebDriver> where TWebDriver : IWebDriver, new() 
        {


            public static void Ndriver()
            {
                IWebDriver driver;
                driver = new TWebDriver();
               
            }

            public static void NewPage()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                driver.Manage().Window.Maximize();
            }


            public static void GoToPage(string test_url)
            {
                IWebDriver driver;
                driver = new TWebDriver();
                driver.Navigate().GoToUrl(test_url);

            }

            public static void ClickRandom()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                pageObjects.HomePage.MultiBroweserDriver.GetRandomButton.Click();
            }

            public static void Stopper()
            {
                IWebDriver driver;
                driver = new TWebDriver();
                driver.Quit();
            }
        }
    }
}


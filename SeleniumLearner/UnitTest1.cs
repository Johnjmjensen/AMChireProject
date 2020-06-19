using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using pageObjects;
 
namespace Selenium_Demo
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    class Selenium_Demo
    {

        
        [Test]
        public void test_random()
        {
            TestActions.TestActions.MultiBroweserDriver.NewPage();
            TestActions.TestActions.MultiBroweserDriver.GoToPage(HomePage.test_url);

            TestActions.TestActions.MultiBroweserDriver.ClickRandom();
 
            System.Threading.Thread.Sleep(6000);
 
            Console.WriteLine("Test Passed");

            
        }
//TODO build out real tests.
    }
}
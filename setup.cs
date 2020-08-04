using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject2
{
    [Binding]
    public class setup
    {
        public static IWebDriver driver;

        public static ISearchContext Driver
        {
            get
            {
                return driver;
            }
        }
        [BeforeFeature]
        public static void Driverlaunch()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [AfterScenario]
        public static void Driverclose()
        {
            driver.Close();
        }
    }
}

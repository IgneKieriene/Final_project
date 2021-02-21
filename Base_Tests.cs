using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace Final_Project.Tests

{
    class Base_Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void BeforeEveryTest()
        {
            //driver = new ChromeDriver();
            
            UseDriver("chrome");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.eavalyne.lt/";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.CssSelector("body > div.popup > div > div > div > section > button:nth-child(2)")).Click();
            
        }
        public void UseDriver(string driverName)
        {
            if (driverName == "chrome")
            {
                driver = new ChromeDriver(MainChromeSettings());
            }
            if (driverName == "firefox")
            {
                driver = new FirefoxDriver();
            }
        }
        public ChromeOptions MainChromeSettings()
        {
            ChromeOptions configurations = new ChromeOptions();
            configurations.AddArgument("incognito");
           
            //configurations.AddArgument("headless");
            return configurations;
        }
        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();
        }

    }
}
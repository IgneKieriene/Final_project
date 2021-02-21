using System;
using System.Threading;
using Final_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Final_Project.Tests
{
    class Main_Page_Tests : Base_Tests
    {
        private Main_Page main_page;

        [SetUp]
        public void BeforeTest()
        {
            main_page = new Main_Page(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 100)");
        }
        [Test]
        public void CheckLanguage()
        {
            Thread.Sleep(2000);
            main_page.PickLanguage();
            Thread.Sleep(1000);
            main_page.CheckLanguage();
        }
        [Test]
        public void CheckHowNavigates()
        {
            Thread.Sleep(2000);
            main_page.CheckNavigation();
         
        }
    }
}

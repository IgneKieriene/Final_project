using System;
using System.Threading;
using Final_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Final_Project.Tests
{
    class Message_Tests : Base_Tests
    {
        private Message message;

        [SetUp]
        public void BeforeTest()
        {
            message = new Message(driver);
            driver.FindElement(By.CssSelector("body > header > div.header-callout > div > a > div")).Click();
        }
        [Test]//for newsletter
        public void RegistrationMessage()
        {
            message.Wait();
            message.EnterEmail();
            Thread.Sleep(2000);
            message.PressToConfirm();
            Thread.Sleep(2000);
            message.CheckText();
            Thread.Sleep(2000);
            message.CheckSuccessMessage();
        }  
    }
}
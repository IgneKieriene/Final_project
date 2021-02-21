using System;
using System.Threading;
using Final_Project.Pages;
using Final_Project.Tests;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Final_Project.Tests
{
    class Input_Fields_Tests :Base_Tests
    {
        private Input_Fields input_fields_page;

        [SetUp]
        public void BeforeTest()
        {
            input_fields_page = new Input_Fields(driver);
            driver.FindElement(By.CssSelector("body > header > div.header-top-bar > div > div > div.header-top-bar__right > div > a:nth-child(5)")).Click();
        }
        [Test]
        public void TextA()
        {
            input_fields_page.EnterName();
            Thread.Sleep(1000);
            input_fields_page.EnterLastName();
            Thread.Sleep(1000);
            input_fields_page.EnterNewEmail();
            Thread.Sleep(1000);
            input_fields_page.EnterPassword();
            Thread.Sleep(1000);
            input_fields_page.ReEnterPassword();
            Thread.Sleep(1000);
            input_fields_page.PressConfirmation();
            Thread.Sleep(1000);
            input_fields_page.PressToCreateAccount();
            Thread.Sleep(1000);
            input_fields_page.CheckTextA();
        }
        [Test]
        public void TextB()
        {
            input_fields_page.EnterName();
            Thread.Sleep(1000);
            input_fields_page.EnterLastName();
            Thread.Sleep(1000);
            input_fields_page.EnterNewEmail();
            Thread.Sleep(1000);
            input_fields_page.EnterPassword();
            Thread.Sleep(1000);
            input_fields_page.ReEnterPassword();
            Thread.Sleep(1000);
            input_fields_page.PressConfirmation();
            Thread.Sleep(1000);
            input_fields_page.PressToCreateAccount();
            Thread.Sleep(1000);
            input_fields_page.CheckTextB();

        }
        [Test]
        public void TextC()
        {
            input_fields_page.EnterName();
            Thread.Sleep(1000);
            input_fields_page.EnterLastName();
            Thread.Sleep(1000);
            input_fields_page.EnterWrongEmail();
            Thread.Sleep(1000);
            input_fields_page.EnterPassword();
            Thread.Sleep(1000);
        }
    }
}
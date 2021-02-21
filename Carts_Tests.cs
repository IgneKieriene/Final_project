using System;
using Final_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Firefox;
using Final_Project.Tests;

namespace Final_Project.Tests
{
    class Carts_Tests : Base_Tests
    {
        private Carts cart;

        [SetUp]
        public void BeforeEveryTest()
        {
            cart = new Carts(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        
        }
        [Test]
        public void CheckCartWithItem()
        {
            cart.PressTheButtons();
            cart.InvestigateCarts();

        }
        [Test]
        public void CheckDiscount()
        {
            cart.PressTheButtons();
            cart.EnterCode();
            cart.CodeConfirmation();
            cart.CheckConfirmationAndClose();
        }
        [Test]
        public void CheckPriceAfterDiscount()
        {
            cart.PressTheButtons();
            cart.EnterCode();
            cart.CodeConfirmation();
            cart.CheckPriceAfterDiscount();
        }
        [Test]
        public void CheckPriceAfterWrongCode()
        {
            cart.PressTheButtons();
            cart.EnterCode();
            cart.CodeConfirmation();
            cart.CheckWrongConfirmationAndClose();
        }



    }
}

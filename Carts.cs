using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Final_Project.Pages
{
    public class Carts :Base_Pages
    {
        public Carts(IWebDriver driver) : base(driver) { }
        //item and price
        private IWebElement Women => driver.FindElement(By.CssSelector(".e-list-item:nth-child(1) > .e-mega-menu__item-link"));
        private IWebElement Shoes => driver.FindElement(By.LinkText("Šlepetės ir basutės"));
        private IWebElement Brand => driver.FindElement(By.CssSelector("[alt='Naminės šlepetės EMU AUSTRALIA - Mayberry W11573 Midnight']"));
        private IWebElement Put => driver.FindElement(By.CssSelector("#product_addtocart_form > section > div.product-right > div > div:nth-child(6) > div.product-right__group > div > button"));
        private IWebElement Size => driver.FindElement(By.CssSelector("##product_addtocart_form > section > div.product-right > div > div:nth-child(6) > div.product-right__size > div > div > div > div.e-size-picker-popup__wrapper > div.e-size-picker-popup__options > button.e-size-picker-option.e-size-picker-option--selected"));
        private IWebElement NavigateToCart => driver.FindElement(By.CssSelector("#product_addtocart_form > section > div.product-right > div > div:nth-child(6) > div.product-right__group > div > div > div > div > div > div.precart-popup__actions > a"));
        private IWebElement Item => driver.FindElement(By.CssSelector("#product_addtocart_form > section > div.product-right > div > div.product-right__group > div.e-heading.e-heading--third-level.e-product-name.e-product-name--only-mobile.product-right__name-wrapper"));
        private IWebElement Price => driver.FindElement(By.CssSelector("#product_addtocart_form > section > div.product-right > div > div.e-product-price.product-right__price > div"));
        //discountmessage
        private IWebElement EnterDiscountCode => driver.FindElement(By.CssSelector("#coupon_code"));
        private IWebElement ConfirmationCode => driver.FindElement(By.CssSelector("#submit-discount-coupon"));
        private IWebElement DiscountMessage => driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > div > ul > li > ul > li > span"));
        private IWebElement WrongDiscountMessage => driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > div > ul > li > ul > li > span"));
        private IWebElement DiscountNoteToSum => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div.cart__bottom > div.cart__totals > div.default.e-cart-total-item > span.e-cart-total-item__label"));
        private IWebElement CloseBox => driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > button"));
        //after discount
        private IWebElement PriceAfterDiscount => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div.cart__bottom > div.cart__totals > div.grandtotal.e-cart-total-item.e-cart-total-item--summary > span.e-cart-total-item__value > span"));

        public void PressTheButtons()
        {
            Thread.Sleep(1000);
            Actions builder = new Actions(driver);
            builder.MoveToElement(Women).Build().Perform();
            Thread.Sleep(3000);
            Shoes.Click();
            Thread.Sleep(1000);
           
            Brand.Click();
            Thread.Sleep(1000);
            Put.Click();
            Thread.Sleep(1000);
            Size.Click();
            Thread.Sleep(1000);
            NavigateToCart.Click();
            Thread.Sleep(2000);

        }
        public void InvestigateCarts()
        {
            Assert.AreEqual("Šlepetės BIG STAR", Item.Text);
            Assert.AreEqual("16,00 €", Price.Text);
        }
        public void EnterCode()
        {
            var builder = new Actions(driver);
            builder.MoveToElement(EnterDiscountCode).SendKeys(EnterDiscountCode, "5LT").Build().Perform();
            Thread.Sleep(1000);
        }
        public void EnterWrongCode()
        {
            var builder = new Actions(driver);
            builder.MoveToElement(EnterDiscountCode).SendKeys(EnterDiscountCode, "blogaskodas").Build().Perform();
            Thread.Sleep(1000);
        }
        public void CodeConfirmation()
        {
            ConfirmationCode.Click();
        }
        public void CheckConfirmationAndClose()
        {
            Assert.AreEqual("Kodas \"5LT\" panaudotas", DiscountMessage.Text);
            //Assert.IsTrue(DiscountMessage.Displayed);
            CloseBox.Click();
            Assert.IsTrue(DiscountNoteToSum.Displayed);
        }
        public void CheckWrongConfirmationAndClose()
        {
            Assert.AreEqual("Kodas \"blogaskodas\" yra neteisingas arba įvykdytos ne visos sąlygos.", WrongDiscountMessage.Text);
            CloseBox.Click();
            
        }
        public void CheckPriceAfterDiscount()
        {
            Assert.AreEqual("54,00 €", PriceAfterDiscount.Text);
        }
    }
}

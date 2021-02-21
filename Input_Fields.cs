using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Final_Project.Pages
{
    public class Input_Fields : Base_Pages
    {
        public Input_Fields(IWebDriver driver) : base(driver) { }

        private IWebElement Name => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div > form > div:nth-child(5) > label"));
        private IWebElement LastName => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div > form > div:nth-child(6) > label"));
        private IWebElement Email => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div > form > div:nth-child(7) > label"));
        private IWebElement WrongEmail => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div > form > div:nth-child(7) > label"));
        private IWebElement Password => driver.FindElement(By.Id("password"));
        private IWebElement RePassword=> driver.FindElement(By.Id("confirmation"));
        private IWebElement Confirmation => driver.FindElement(By.CssSelector(".checkbox-wrapper:nth-child(11) svg"));
        private IWebElement CreateAccount => driver.FindElement(By.Id("create-account"));
        private IWebElement TextA => driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > div > ul > li > ul > li > span"));
        private IWebElement TextB => driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > div > ul > li > ul > li > span"));
        private IWebElement TextC => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div > form > div.input-wrapper.input-wrapper--floating-label.has-error > span"));

        public void EnterName()
        {
            var builder = new Actions(driver); //Action builder = new Action (driver)
            builder.MoveToElement(Name).SendKeys(Name, "jonas").Build().Perform();
        }
        public void EnterLastName()
        {
            var builder = new Actions(driver);
            builder.MoveToElement(LastName).SendKeys(LastName, "jonaitis").Build().Perform();
        }
        public void EnterNewEmail()//new email for testing
        {
            var builder = new Actions(driver);
            builder.MoveToElement(Email).SendKeys(Email, "labadic@gmail.com").Build().Perform();
        }
        public void EnterEmail()
        {
            var builder = new Actions(driver);
            builder.MoveToElement(Email).SendKeys(Email, "labas@gmail.com").Build().Perform();
        }
        public void EnterWrongEmail()
        {
            var builder = new Actions(driver);
            builder.MoveToElement(WrongEmail).SendKeys(WrongEmail, "labas.com").Build().Perform();
        }
        public void EnterPassword()
        {
            Password.SendKeys("labass");
        }
        public void ReEnterPassword()
        {
            RePassword.SendKeys("labass");
        }
        public void PressConfirmation()
        {
           Confirmation.Click();
        }
        public void PressToCreateAccount()
        {
            CreateAccount.Click();
        }
        public void CheckTextA()
        {
            Assert.AreEqual("Dėkojame už registraciją eavalyne.lt.", TextA.Text);
        }
        public void CheckTextB()
        { 
            Assert.AreEqual("Paskyra šiuo el.pašto adresu jau yra. Jei tai Jūsų el.pašto adresas, spustelėkite čia, kad iš naujo nustatyti slaptažodį ir prisijungti prie savo paskyros.", TextB.Text);
        }
        public void CheckTextC()
        {
            Assert.AreEqual("Neteisingai įvestas el. pašto adresas", TextC.Text);
        }
    }
}

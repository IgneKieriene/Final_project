using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Final_Project.Pages
{
    public class Message : Base_Pages
    {
        public Message(IWebDriver driver) : base(driver) { }

        //newsletter
        private IWebElement Email => driver.FindElement(By.CssSelector("#popup-form > input"));
        private IWebElement Button => driver.FindElement(By.ClassName("button"));
        private IWebElement Text => driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > div > ul > li > ul > span"));
        //close message
        private IWebElement CloseMessage => driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > button"));
        
        private IWebElement NormalSuccessMessage
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("body > div:nth-child(2) > ul > li > div > ul > li > ul > li"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        public void Wait()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#popup-form")));
        }
        public void EnterEmail()
        {  
            var builder = new Actions(driver);
            builder.MoveToElement(Email).SendKeys(Email, "okooo00001123454@gmail.com").Build().Perform();
            //new email for test
        }
        public void PressToConfirm()
        {
           Button.Click();
        }
        public void CheckText()
        {
            Assert.AreEqual("Užklausos patvirtinimas išsiųstas.", Text.Text);
        }
        public void CheckSuccessMessage()
        {
            Assert.IsNotNull(Text);
            CloseMessage.Click();
            Assert.IsNull(Text);
        }
    }
}
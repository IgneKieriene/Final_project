using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Final_Project.Pages
{
    public class Main_Page : Base_Pages
    {
      public Main_Page(IWebDriver driver) : base(driver) { }
        //language test
        private IWebElement LanguageButton => driver.FindElement(By.CssSelector(".vs__open-indicator"));
        private IWebElement Language => driver.FindElement(By.CssSelector(".footer__content"));
        private IWebElement Confirmation => driver.FindElement(By.CssSelector("body > div.popup > div > div > div > section > button:nth-child(2)"));
        private IWebElement CompareLanguage => driver.FindElement(By.CssSelector("#brand_slider_unisex > section > h3"));
        //navigation test
        private IWebElement Navigation => driver.FindElement(By.CssSelector("body > footer > div > div.footer__content > div:nth-child(4) > ul > li:nth-child(1) > a"));


      public void PickLanguage()
      {
            Thread.Sleep(1000);
            LanguageButton.Click();
            Thread.Sleep(1000);
            Actions builder = new Actions(driver);
            builder.MoveToElement(Language).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(2000);
            Confirmation.Click();
            
      }
      public void CheckLanguage()
      {
            Thread.Sleep(2000);
            Assert.AreEqual("Popularne marki", CompareLanguage.Text);
            
      }
      public void CheckNavigation()
      {
            Navigation.Click();
            Assert.AreEqual("https://www.eavalyne.lt/kaip-pirkti", driver.Url);
      }

    }
}           

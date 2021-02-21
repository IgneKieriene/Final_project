using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Final_Project.Pages
{
    public class Favorites : Base_Pages
    {
      public Favorites (IWebDriver driver) : base(driver) { }
            //favorites
      private IWebElement Women => driver.FindElement(By.CssSelector(".e-list-item:nth-child(1) > .e-mega-menu__item-link"));
      private IWebElement Shoes => driver.FindElement(By.LinkText("Šlepetės ir basutės"));
      private IWebElement Heart => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > div.category-grid__main > ul > li:nth-child(3) > div > button > svg")); 
      private IWebElement FavoriteButton => driver.FindElement(By.CssSelector("body > header > div.header-top-bar > div > div > div.header-top-bar__right > div > a:nth-child(3)"));
      private IWebElement FavoriteItem => driver.FindElement(By.CssSelector("body > div.one-col-wrapper > div > ul > li:nth-child(1) > div > a > h2 > span.products-list__name-first"));
      public void PressTheButtons()
      {
        Thread.Sleep(1000);
        Actions builder = new Actions(driver);
        builder.MoveToElement(Women).Build().Perform();
        Thread.Sleep(1000);
        Shoes.Click();
        Thread.Sleep(1000);
        Heart.Click();
        Thread.Sleep(2000);
        FavoriteButton.Click();
        Thread.Sleep(1000);

      }
      public void CheckFavoritesPage()
      {
        Assert.AreEqual("Šlepetės adidas", FavoriteItem.Text);

      }
            
    }
}

using System;
using Final_Project.Pages;
using NUnit.Framework;
using Final_Project.Tests;


namespace Final_Project.Tests
{
    class Favorite_Tests : Base_Tests
    {
        private Favorites  heart;

        [SetUp]
        public void BeforeEveryTest()
        {
            heart = new Favorites(driver);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [Test]
        public void CheckFavoritesPage()
        {
            heart.PressTheButtons();
            heart.CheckFavoritesPage();

        }
    }
}

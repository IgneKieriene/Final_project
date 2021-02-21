using System;
using OpenQA.Selenium;

namespace Final_Project.Pages
{
    public class Base_Pages
    {
        protected IWebDriver driver;
        public Base_Pages(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}

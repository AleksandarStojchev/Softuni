using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages
{
    public class BasePage
    {

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebDriver Driver { get; }
        public virtual string URL { get; set; }

        public WebDriverWait Wait { get; set; }

        public void NavigateTo ()
        {
            Driver.Navigate().GoToUrl(URL);
        }

        public void WaitForPageToLoad(int timeoutSec=15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

        public IWebElement ScroolTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
    }
}

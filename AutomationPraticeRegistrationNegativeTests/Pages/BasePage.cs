using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Window.Maximize();
        }
        public IWebDriver Driver { get; }
        public IWebElement ScroolTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}

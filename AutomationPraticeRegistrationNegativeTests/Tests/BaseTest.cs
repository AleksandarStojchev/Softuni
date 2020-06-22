using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Tests
{
   public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace InteractionTests.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        protected Actions Builder;
        

        public void Initalize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
            Builder = new Actions(Driver);
        }
    }
}

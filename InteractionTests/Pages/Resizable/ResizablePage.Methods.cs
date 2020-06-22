using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.Resizable
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
            : base(driver)
        {
        }
        public override string URL => "http://www.demoqa.com/resizable";
    }
}

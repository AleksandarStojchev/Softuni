using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.HomePage
{
   public partial class HomePage : BasePage
    {
        public override string URL => "http://www.demoqa.com";
        public IWebElement InteractionButton => Driver.FindElement(By.XPath("//div[@class=\"card mt-4 top-card\"]//h5[normalize-space(text())=\"Interactions\"]"));
    }
}

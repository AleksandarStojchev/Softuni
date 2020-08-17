using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InteractionTests.Pages.InteracctionsHomePage
{
    // The page represents the exercise page when Interaction button on home page is clicked
    public partial class InteractionsHomePage : BasePage
    {
        public override string URL => "http://www.demoqa.com/interaction";
        public IWebElement InteractionMenu => Driver.FindElement(By.XPath("//div[@class=\"header-wrapper\"]//div[normalize-space(text())=\"Interactions\"]"));
    }
}

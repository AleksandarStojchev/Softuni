using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.InteracctionsHomePage
{
    public partial class InteractionsHomePage : BasePage
    {
        public InteractionsHomePage(IWebDriver driver)
            : base(driver)
        {
        }
        public override string URL => "http://www.demoqa.com/interaction";
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
       public IWebElement SignInButton => Driver.FindElement(By.XPath("//a[normalize-space(text())=\"Sign in\"]"));

    }
}

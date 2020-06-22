using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Pages.CreateAccountEmailPage
{
    public partial class CreateAcccountEmailPage : BasePage
    {
        public IWebElement EmailAddresCreateAcc => Driver.FindElement(By.Id("email_create"));
        public IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

    }
}

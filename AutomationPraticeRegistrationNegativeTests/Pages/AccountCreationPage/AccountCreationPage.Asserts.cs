using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Pages.AccountCreationPage
{
    public partial class AccountCreation : BasePage
    {

        public void AssertFieldIsRequired(string fieldErrorMessage)
        {

            var actualMessage = Driver.FindElement(By.XPath("//*[@id=\"center_column\"]//ancestor::ol")).Text;

            Assert.AreEqual(fieldErrorMessage, actualMessage);
        }
    }
}

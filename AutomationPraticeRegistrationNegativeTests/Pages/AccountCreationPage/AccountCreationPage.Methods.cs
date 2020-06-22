using AutomationPraticeRegistrationNegativeTests.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Pages.AccountCreationPage
{
    public partial class AccountCreation : BasePage
    {
        public AccountCreation(IWebDriver driver) 
            : base(driver)
        {
        }
        public void FillForm(FormModel user)
        {
            FirstNameField.SendKeys(user.FirstName);
            LastNameField.SendKeys(user.LastName);
            PasswordField.SendKeys(user.PasswordField);
            Address1.SendKeys(user.Address1);
            City.SendKeys(user.City);
            State.Click();
            SelectElement stateValue = new SelectElement(State);
            stateValue.SelectByIndex(user.State);
            ZipCode.SendKeys(user.ZipCode);
            MobilePhone.SendKeys(user.MobilePhone);
            AssignAnAddresAlias.SendKeys(user.AssignAnAddresAlias);
            
            ScroolTo(RegisterButton).Click();

        }
    }
}

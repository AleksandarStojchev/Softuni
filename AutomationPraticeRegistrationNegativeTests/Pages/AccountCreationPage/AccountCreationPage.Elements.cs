using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPraticeRegistrationNegativeTests.Pages.AccountCreationPage
{
    public partial class AccountCreation : BasePage
    {

        public IWebElement FirstNameField => Driver.FindElement(By.Id("customer_firstname"));
        public IWebElement LastNameField => Driver.FindElement(By.Id("customer_lastname"));
        public IWebElement EmailFieldFromRegistration => Driver.FindElement(By.Id("email"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("passwd"));
        public IWebElement Address1 => Driver.FindElement(By.Id("address1"));
        public IWebElement City => Driver.FindElement(By.Id("city"));
        public IWebElement State => Driver.FindElement(By.Id("id_state"));
        public IWebElement ZipCode => Driver.FindElement(By.Id("postcode"));
        public IWebElement Country => Driver.FindElement(By.Id("id_country"));
        public IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));
        public IWebElement AssignAnAddresAlias => Driver.FindElement(By.Id("alias"));
        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

        public WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

    }
}

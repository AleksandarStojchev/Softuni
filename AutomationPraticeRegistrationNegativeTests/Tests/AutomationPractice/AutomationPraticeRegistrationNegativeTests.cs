using AutomationPraticeRegistrationNegativeTests.Models;
using AutomationPraticeRegistrationNegativeTests.Pages.AccountCreationPage;
using AutomationPraticeRegistrationNegativeTests.Pages.CreateAccountEmailPage;
using AutomationPraticeRegistrationNegativeTests.Pages.HomePage;
using AutomationPraticeRegistrationNegativeTests.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationPraticeRegistrationNegativeTests.Factories;

namespace AutomationPraticeRegistrationNegativeTests
{
    [TestFixture]
    public class AutomationPraticeRegistrationNegativeTests : BaseTest
    {
        private HomePage home;
        private AccountCreation accountPage;
        private FormModel user;
        CreateAcccountEmailPage createAcccountEmail;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            home = new HomePage(Driver);
            accountPage = new AccountCreation(Driver);

            user = FormFactory.Create();
            createAcccountEmail = new CreateAcccountEmailPage(Driver);

            NavigateToForm();

        }
        [Test]
        public void LastNameShouldBeRequired()
        {

            user.LastName = string.Empty;

            accountPage.FillForm(user);

            accountPage.AssertFieldIsRequired("lastname is required.");

        }
        [Test]
        public void EmailShouldBeRequired()
        {
            IWebElement EmailFieldFromRegistration = Driver.FindElement(By.Id("email"));
            EmailFieldFromRegistration.Clear();

            accountPage.FillForm(user);

            accountPage.AssertFieldIsRequired("email is required.");

        }

        [Test]
        public void Address1ShouldBeRequired()
        {

            user.Address1 = string.Empty;

            accountPage.FillForm(user);

            accountPage.AssertFieldIsRequired("address1 is required.");

        }

        [Test]
        public void PasswordShouldBeRequired()
        {

            user.PasswordField = string.Empty;

            accountPage.FillForm(user);

            accountPage.AssertFieldIsRequired("passwd is required.");

        }

        [Test]
        public void AtLeastOnePhoneNumberShouldBeRequired()
        {

            user.MobilePhone = null;

            accountPage.FillForm(user);

            accountPage.AssertFieldIsRequired("You must register at least one phone number.");

        }
        [Test]
        public void CityShouldBeRequired()
        {

            user.City = string.Empty;

            accountPage.FillForm(user);

            accountPage.AssertFieldIsRequired("city is required.");

        }
        
        internal void NavigateToForm()
        {

            home.SignInButton.Click();

            createAcccountEmail.EmailAddresCreateAcc.SendKeys("mbrf@sdjn.com");
            createAcccountEmail.CreateAccountButton.Click();

            accountPage.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("account-creation_form")));
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}

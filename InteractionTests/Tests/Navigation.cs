using InteractionTests.Pages.HomePage;
using InteractionTests.Pages.InteracctionsHomePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InteractionTests.Tests
{
    public class Navigation : BaseTest
    {
        private InteractionsHomePage _interactionsHomePage;

        [SetUp]
        public void SetUp()
        {
            Initalize();
            _interactionsHomePage = new InteractionsHomePage(Driver);
            _interactionsHomePage.NavigateTo();

        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void SuccessfullyNavigateToAllInteractionExercises(string execrize)
        {
            IWebElement currentExercize = Driver.FindElement(By.XPath($"//span[normalize-space(text())='{execrize}']"));
            _interactionsHomePage.ScroolTo(currentExercize);

            Assert.AreEqual(execrize, currentExercize.Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}

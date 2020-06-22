using InteractionTests.Pages.Resizable;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace InteractionTests.Tests.Interactions
{
    public class ResizableTests : BaseTest
    {
        ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initalize();
            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigateTo();
        }
        [Test]
        public void BoxShouldChangeItSize()
        {

            var initialSize = _resizablePage.ResizableBoxInner.Size.ToString();

            Builder.ClickAndHold(_resizablePage.ResizableArrowInBox).MoveByOffset(50, 50).Release().Perform();

            var afterSize = _resizablePage.ResizableBoxInner.Size.ToString();

            Assert.AreNotEqual(initialSize, afterSize);

        }

        [Test]
        public void InnerBoxCantBeBiggerThanOutter()
        {

            Assert.Throws<WebDriverException>(() =>
           {
               Builder.ClickAndHold(_resizablePage.ResizableArrowInBox)
               .MoveByOffset(500, 500)
               .Release()
               .Perform();
           });

        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}

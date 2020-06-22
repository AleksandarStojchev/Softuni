using InteractionTests.Pages.Droppable;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace InteractionTests.Tests.Interactions
{
    public class DroppableTests : BaseTest
    {
        private DroppablePage _droppablePage;
        private WebDriverWait Wait;

        [SetUp]
        public void SetUp()
        {
            Initalize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }

        [Test]
        public void TargetBoxShouldChangeText()
        {

            Builder.DragAndDrop(_droppablePage.DragMeBox, _droppablePage.DropHereBoxSimpe).Perform();


            string actualTargetBoxText = _droppablePage.DropHereBoxSimpe.Text;

            string expectedTargetBoxText = "Dropped!";

            Assert.AreEqual(expectedTargetBoxText, actualTargetBoxText);

        }
        [Test]
        public void TargetBoxShouldNotChangeText()
        {

            _droppablePage.AcceptTab.Click();

            string expectedText = "Drop here";

            Builder.ClickAndHold(_droppablePage.NotAcceptableBox)
                .MoveToElement(_droppablePage.DropHereBoxAcceptable)
                .Perform();

            Assert.AreEqual(expectedText, _droppablePage.DropHereBoxAcceptable.Text, "Target box should not change text when non accaptable box is dropped.");
           
        }


        [Test]
        public void RevertBoxShouldBeReverted()
        {
            _droppablePage.RevertDraggableTab.Click();
            double sumOfCoordinatesWhenInBox = 1414;


            Builder.DragAndDrop(_droppablePage.RevertBox, _droppablePage.DropHereBoxRevertDraggable)
                .Perform();

            Wait.Until(ExpectedConditions.TextToBePresentInElement(_droppablePage.DropHereBoxRevertDraggable, "Dropped!"));
            double sumOfCoordinatesAfter = _droppablePage.RevertBox.Location.X + _droppablePage.RevertBox.Location.Y;

            Assert.AreNotEqual(sumOfCoordinatesAfter, sumOfCoordinatesWhenInBox);

        }
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string path = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{path}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit();
        }
    }
}

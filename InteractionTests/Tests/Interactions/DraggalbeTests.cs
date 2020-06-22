using InteractionTests.Pages.Draggable;
using NUnit.Framework;

namespace InteractionTests.Tests.Interactions
{
    [TestFixture]
    public class DraggableTests : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initalize();
            _draggablePage = new DraggablePage(Driver);
            _draggablePage.NavigateTo();
        }
        [Test]
        public void TargetShouldChangePossition()
        {

            string dragMeBoxPossitionBefore = "X: " + _draggablePage.DragMeBox.Location.X.ToString() + 
                ", Y: " + _draggablePage.DragMeBox.Location.Y.ToString();

            Builder.ClickAndHold(_draggablePage.DragMeBox).MoveByOffset(300, 400).Perform();

            string dragMeBoxPossitionAfter = "X: " + _draggablePage.DragMeBox.Location.X.ToString() +
                ", Y: " + _draggablePage.DragMeBox.Location.Y.ToString();

            Assert.AreNotEqual(dragMeBoxPossitionAfter, dragMeBoxPossitionBefore);

        }

        [Test]
        public void BoxShouldChangeOnlyXCoordinates()
        {
            _draggablePage.AxisTab.Click();


            int xCoordinatesBefore = _draggablePage.OnlyXBox.Location.X;
            int yCoordinatesBefore = _draggablePage.OnlyXBox.Location.Y;

            Builder.ClickAndHold(_draggablePage.OnlyXBox).MoveByOffset(150, 100).Perform();

            int xCoordinatesAfter = _draggablePage.OnlyXBox.Location.X;
            int yCoordinatesAfter = _draggablePage.OnlyXBox.Location.Y;

            _draggablePage.AssertXCoordinateIsChanged(xCoordinatesBefore, yCoordinatesBefore, xCoordinatesAfter, yCoordinatesAfter);

        }

        [Test]
        public void BoxShouldChangeOnlyYCoordinates()
        {
            _draggablePage.AxisTab.Click();


            int xCoordinatesBefore = _draggablePage.OnlyYBox.Location.X;
            int yCoordinatesBefore = _draggablePage.OnlyYBox.Location.Y;

            Builder.ClickAndHold(_draggablePage.OnlyYBox).MoveByOffset(150, 100).Perform();

            int xCoordinatesAfter = _draggablePage.OnlyYBox.Location.X;
            int yCoordinatesAfter = _draggablePage.OnlyYBox.Location.Y;

            _draggablePage.AssertYCoordinateIsChanged(xCoordinatesBefore, yCoordinatesBefore, xCoordinatesAfter, yCoordinatesAfter);

        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}

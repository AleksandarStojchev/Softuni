using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.Draggable
{
   public partial class DraggablePage : BasePage
    {
        public void AssertXCoordinateIsChanged(int xCoordinatesBefore, int yCoordinatesBefore, int xCoordinatesAfter, int yCoordinatesAfter)
        {


            Assert.AreNotEqual(xCoordinatesAfter, xCoordinatesBefore, "X coordinate is not chaged!");
            Assert.AreEqual(yCoordinatesAfter, yCoordinatesBefore, "Y coordinate is  chaged!");
        }

        public void AssertYCoordinateIsChanged(int xCoordinatesBefore, int yCoordinatesBefore, int xCoordinatesAfter, int yCoordinatesAfter)
        {


            Assert.AreEqual(xCoordinatesAfter, xCoordinatesBefore, "X  coordinate is chaged!");
            Assert.AreNotEqual(yCoordinatesAfter, yCoordinatesBefore, "Y coordinate is not chaged!");
        }
    }
}

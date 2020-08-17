using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public override string URL => "http://www.demoqa.com/dragabble";

        //Elements from simple tab
        public IWebElement SimpleTab => Driver.FindElement(By.Id("draggableExample-tab-simple"));

        public IWebElement DragMeBox => Driver.FindElement(By.Id("dragBox"));

        //Axis tab elements
        public IWebElement AxisTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        public IWebElement OnlyXBox => Driver.FindElement(By.Id("restrictedX"));
        public IWebElement OnlyYBox => Driver.FindElement(By.Id("restrictedY"));

        //Other tabs
        public IWebElement ContainerRestricntedTab => Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));
        public IWebElement CursorStyleTab => Driver.FindElement(By.Id("draggableExample-tab-cursorStyle"));



    }
}

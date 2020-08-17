using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.Droppable
{
    public partial class DroppablePage : BasePage
    {
        public override string URL => "http://www.demoqa.com/droppable";

        //Elements from Simple tab
        public IWebElement SimpleTab => Driver.FindElement(By.XPath("*//a[normalize-space(text())='Simple']"));
        public IWebElement DragMeBox => Driver.FindElement(By.Id("draggable"));
        public IWebElement DropHereBoxSimpe => Driver.FindElement(By.Id("droppable"));


        // Elements from Accept tab
        public IWebElement AcceptTab => Driver.FindElement(By.XPath("//a[normalize-space(text())=\"Accept\"]"));
        public IWebElement AcceptableBox => Driver.FindElement(By.Id("acceptable"));
        public IWebElement NotAcceptableBox => Driver.FindElement(By.Id("notAcceptable"));
        public IWebElement DropHereBoxAcceptable => Driver.FindElement(By.XPath("//div[@class=\"accept-drop-container\"]//child::div[@id=\"droppable\"]"));



        //Prevent Propogation tab
        public IWebElement PreventPropogationTab => Driver.FindElement(By.XPath("//a[normalize-space(text())='Prevent Propogation']"));

        //Elements fromRevert Draggable tab
        public IWebElement RevertDraggableTab => Driver.FindElement(By.XPath("//a[normalize-space(text())='Revert Draggable']"));

        public IWebElement RevertBox => Driver.FindElement(By.XPath("//div[normalize-space(text())='Will Revert']"));
        public IWebElement NotRevertBox => Driver.FindElement(By.XPath("//div[normalize-space(text())='Not Revert']"));
        public IWebElement DropHereBoxRevertDraggable => Driver.FindElement(By.XPath("//div[@class=\"revertable-drop-container\"]//child::div[@id=\"droppable\"]"));


    }
}

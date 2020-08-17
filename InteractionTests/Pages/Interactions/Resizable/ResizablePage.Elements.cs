using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.Resizable
{
    public partial class ResizablePage
    {
        public override string URL => "http://www.demoqa.com/resizable";
        public IWebElement ResizableArrowInBox => Driver.FindElement(By.XPath("//div[@id=\"resizableBoxWithRestriction\"]/span[@class=\"react-resizable-handle react-resizable-handle-se\"]"));
        public IWebElement ResizableBoxInner => Driver.FindElement(By.XPath("//*[@id=\"resizableBoxWithRestriction\"]"));
        public IWebElement OuterBox => Driver.FindElement(By.XPath("//div[@class=\"constraint-area\"]"));

    }
}

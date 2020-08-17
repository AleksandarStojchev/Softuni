using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.Selectable
{
    public partial class SelectablePage
    {
        public override string URL => "http://www.demoqa.com/selectable";
        public IWebElement PortaElement => Driver.FindElement(By.XPath("*//li[normalize-space(text())=\"Porta ac consectetur ac\"]"));
        public IWebElement GridTab => Driver.FindElement(By.XPath("*//a[normalize-space(text())=\"Grid\"]"));
        public IWebElement FiveElement => Driver.FindElement(By.XPath("*//li[normalize-space(text())=\"Five\"]"));

    }
}

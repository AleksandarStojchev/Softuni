using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTests.Pages.Sortable
{
   public partial class SortablePage : BasePage
    {
        public override string URL => "http://www.demoqa.com/sortable";
        public IWebElement ElementsContainerList => Driver.FindElement(By.XPath("//div[@class=\"vertical-list-container mt-4\"]"));
        public IWebElement TwoElement => Driver.FindElement(By.XPath("//div[@class=\"vertical-list-container mt-4\"]//div[normalize-space(text())=\"Two\"]"));
    }
}

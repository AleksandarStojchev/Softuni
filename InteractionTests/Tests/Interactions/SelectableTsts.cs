using InteractionTests.Pages.Selectable;
using NUnit.Framework;

namespace InteractionTests.Tests.Interactions
{
    public class SelectableTsts : BaseTest
    {
        private SelectablePage _SelectablePage;

        [SetUp]
        public void SetUp()
        {
            Initalize();
            _SelectablePage = new SelectablePage(Driver);

            _SelectablePage.NavigateTo();
        }

        [Test]
        public void SelectableList()
        { 
           
            string backgroundColorOfElement = _SelectablePage.PortaElement.GetCssValue("background-color");

            _SelectablePage.PortaElement.Click();

            string afterBackcolor = _SelectablePage.PortaElement.GetCssValue("background-color");

            Assert.AreNotEqual(backgroundColorOfElement, afterBackcolor);
        }

        [Test]
        public void SelectableFromGrid()
        {
            _SelectablePage.GridTab.Click();


            _SelectablePage.FiveElement.Click();

            //The class should be changed due to selecting
            string expectedClassToBe = "list-group-item active list-group-item-action";

            string actualClass = _SelectablePage.FiveElement.GetAttribute("class").ToString();

            Assert.AreEqual(expectedClassToBe, actualClass, "The object is not selected!");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}

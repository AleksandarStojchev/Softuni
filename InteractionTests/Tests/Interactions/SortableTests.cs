using InteractionTests.Pages.Sortable;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace InteractionTests.Tests.Interactions
{
    public class SortableTests : BaseTest
    {
        private SortablePage _SortablePAge;

        [SetUp]
        public void SetUp()
        {
            Initalize();
            _SortablePAge = new SortablePage(Driver);
            _SortablePAge.NavigateTo();
        }
        [Test]
        public void ListShouldNotBeSorted()
        {

            var elements = _SortablePAge.ElementsContainerList.Text;

            // Getting all inner div's from container and putting them to list

            List<string> sortedElements = elements
                .Split("\r\n")
                .ToList();

            Builder.ClickAndHold(_SortablePAge.TwoElement)
                .MoveByOffset(150, 100)
                .Release()
                .Perform();

            List<string> elementsAfterMoving = _SortablePAge.ElementsContainerList
                .Text
                .Split("\r\n")
                .ToList();

            Assert.AreNotEqual(sortedElements, elementsAfterMoving);
        }

        [Test]
        public void ElementsShouldBeSortedAfterRefresh()
        {

            var elements = _SortablePAge.ElementsContainerList.Text;

            // Getting all inner div's from container and putting them to list
            Builder.ClickAndHold(_SortablePAge.TwoElement)
                .MoveByOffset(150, 100)
                .Release()
                .Perform();

            List<string> sortedElements = elements
                .Split("\r\n")
                .ToList();

            Driver.Navigate().Refresh();

            List<string> elementsAfterRefreshing = _SortablePAge.ElementsContainerList
                .Text
                .Split("\r\n")
                .ToList();

            Assert.AreEqual(sortedElements, elementsAfterRefreshing);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}

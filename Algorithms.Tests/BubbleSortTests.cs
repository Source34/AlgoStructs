using Algorithms.Utils;
using Algorithms.Sorting;
using Algorithms.Tests.Utils;

namespace Algorithms.Tests
{
    public class BubbleSortTests
    {
        [Test]
        [TestCase(100, SortDirection.Descending, TestName = "Arr = 100, Direction = desc, Values = [-100;100]")]
        [TestCase(1000, SortDirection.Descending, TestName = "Arr = 1000, Direction = desc, Values = [-100;100]")]
        [TestCase(10000, SortDirection.Descending, TestName = "Arr = 10000, Direction = desc, Values = [-100;100]")]
        [TestCase(50000, SortDirection.Descending, TestName = "Arr = 50000, Direction = desc, Values = [-100;100]")]
        [TestCase(100000, SortDirection.Descending, TestName = "Arr = 100000, Direction = desc, Values = [-100;100]")]
        [TestCase(500000, SortDirection.Descending, TestName = "Arr = 500000, Direction = desc, Values = [-100;100]")]
        public void IsCorrectDescSort_WithDiffCollectionSize_ShouldBeTrue(int size, SortDirection direction)
        {
            var testDataSet = TestDataGenerator.GetIntCollection(size);

            var result = testDataSet.BubbleSort(direction);

            Assert.That(SortValidator.IsSortedIntCollection(result, direction), Is.True);

        }

        [Test]
        [TestCase(100, SortDirection.Ascending, TestName = "Arr = 100, Direction = asc, Values = [-100;100]")]
        [TestCase(1000, SortDirection.Ascending, TestName = "Arr = 1000, Direction = asc, Values = [-100;100]")]
        [TestCase(10000, SortDirection.Ascending, TestName = "Arr = 10000, Direction = asc, Values = [-100;100]")]
        [TestCase(50000, SortDirection.Ascending, TestName = "Arr = 50000, Direction = asc, Values = [-100;100]")]
        [TestCase(100000, SortDirection.Ascending, TestName = "Arr = 100000, Direction = asc, Values = [-100;100]")]
        //[TestCase(500000, SortDirection.Ascending, TestName = "Arr = 500000, Direction = asc, Values = [-100;100]")]
        public void IsCorrectAscSort_WithDiffCollectionSize_ShouldBeTrue(int size, SortDirection direction)
        {
            var testDataSet = TestDataGenerator.GetIntCollection(size);

            var result = testDataSet.BubbleSort(direction);

            Assert.That(SortValidator.IsSortedIntCollection(result, direction), Is.True);

        }
    }
}
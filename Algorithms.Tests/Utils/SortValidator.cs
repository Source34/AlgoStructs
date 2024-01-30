using Algorithms.Utils;

namespace Algorithms.Tests.Utils
{
    internal static class SortValidator
    {
        internal static bool IsSortedIntCollection(IEnumerable<int> collection, SortDirection direction)
        {
            Compare isCompareCondition = 
                direction == SortDirection.Descending ? SortUtils.IsGreaterOrEqual : SortUtils.IsLessOrEqual;

            var arrCollection = collection.ToArray();
            var size = arrCollection.Length;

            for (var i = 0; i < size - 1; i++)
            {
                if (!isCompareCondition(arrCollection[i], arrCollection[i + 1]))
                    return false;
            }

            return true;
        }
    }
}
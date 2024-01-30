using Algorithms.Utils;

namespace Algorithms.Sorting
{
    public static class BubbleSortExtension
    {
        public static IEnumerable<int> BubbleSort(this IEnumerable<int> data, SortDirection direction = SortDirection.Descending)
        {
            Compare compare = direction == SortDirection.Descending ? SortUtils.IsLess : SortUtils.IsGreater;

            var arr = data.ToArray();
            var length = arr.Length;

            for (var i = 0; i < length - 1; i++)
            for (var j = i; j < length - 1; j++)
                if (compare(arr[i], arr[j + 1]))
                    (arr[i], arr[j + 1]) = (arr[j + 1], arr[i]);

            return arr;
        }
    }
}
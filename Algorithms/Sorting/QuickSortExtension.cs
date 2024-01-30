using Algorithms.Utils;

namespace Algorithms.Sorting
{
    public static class QuickSortExtension
    {
        private static Compare[] _compareFuncs = new Compare[2];
        public static IEnumerable<int> QuickSort(this IEnumerable<int> data, SortDirection direction = SortDirection.Descending)
        {
            var arr = data.ToArray();

            if (arr.Length <= 1)
                return arr;

            _compareFuncs = direction == SortDirection.Descending ?                 
                new Compare[]
                {
                    SortUtils.IsGreaterOrEqual,
                    SortUtils.IsLess
                } :
                new Compare[]
                {
                    SortUtils.IsLessOrEqual,
                    SortUtils.IsGreater
                };

            var pivot = arr[0];
            var lessArr = arr.Skip(1).Where(p => _compareFuncs[0](p, pivot));
            var greaterArr = arr.Skip(1).Where(p => _compareFuncs[1](p, pivot));

            return QuickSort(lessArr, direction)
                .Concat(new [] { pivot })
                .Concat(QuickSort(greaterArr, direction));
        }
    }
}

using Algorithms.Sortings;
using Algorithms.Tests.Utils;
using Algorithms.Utils;

namespace Sandbox
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = TestDataGenerator.GetIntCollection(100);
            var res = data.QuickSort(SortDirection.Descending);

            foreach (var item in res)
                Console.WriteLine(item);
        }
    }
}
namespace Algorithms.Tests.Utils
{
    internal static class TestDataGenerator
    {
        /// <summary>
        /// Generating int data collection with values between -100 and 100 
        /// </summary>
        /// <param name="size">Size of the data collection</param>
        /// <returns></returns>
        internal static IEnumerable<int> GetIntCollection(int size)
        {           
            const int minValue = -100;
            const int maxValue = 100;
            var valueRnd= new Random();
            var values = new int[size];
 

            for (var i = 0; i < size; i++)
                values[i] = valueRnd.Next(minValue, maxValue);
                                    
            return values;
        }

        /// <summary>
        /// Generating int data collection
        /// </summary>
        /// <param name="size">Size of the data collection</param>
        /// <param name="minValue">Minimal value in collection</param>
        /// <param name="maxValue">Maximum value in collection</param>
        /// <returns></returns>
        internal static IEnumerable<int> GetIntCollection(int size, int minValue, int maxValue)
        {
            var valueRnd = new Random();
            var values = new int[size];

            for (var i = 0; i < size; i++)
                values[i] = valueRnd.Next(minValue, maxValue);

            return values;
        }
    }
}

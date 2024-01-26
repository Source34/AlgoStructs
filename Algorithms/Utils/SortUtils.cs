namespace Algorithms.Utils
{
    public static class SortUtils
    {
        public static bool IsGreater(int x, int y)
        {
            return x > y;
        }
        public static bool IsGreaterOrEqual(int x, int y)
        {
            return x > y || x == y;
        }
        public static bool IsLess(int x, int y)
        {
            return x < y;
        }
        public static bool IsLessOrEqual(int x, int y)
        {
            return x < y || x == y;
        }

        internal static bool IsGreater(float x, float y)
        {
            return x > y;
        }

        internal static bool IsLess(float x, float y)
        {
            return x < y;
        }

        internal static bool IsGreater(double x, double y)
        {
            return x > y;
        }

        internal static bool IsLess(double x, double y)
        {
            return x < y;
        }

        internal static bool IsGreater(decimal x, decimal y)
        {
            return x > y;
        }

        internal static bool IsLess(decimal x, decimal y)
        {
            return x < y;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Utils.Extensions
{
    public static class EnumerableExtensions
    {
        public static Random Rnd = new Random();

        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.ToArray().Random();
        }

        public static T Random<T>(this T[] array)
        {
            return array[Rnd.Next(array.Length)];
        }
    }
}

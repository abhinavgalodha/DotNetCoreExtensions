using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreExtensions
{
    public static class ListExtensions
    {
        public static void Swap<T>(this IList<T> collection, int leftIndex, int rightIndex)
        {
            collection.ThrowIfNull(nameof(collection));

            if (leftIndex < collection.Count ||
                rightIndex < collection.Count)
            {
                T temp = collection[leftIndex];
                collection[leftIndex] = collection[rightIndex];
                collection[rightIndex] = temp;
            }
        }
    }
}

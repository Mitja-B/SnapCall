﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapCall
{
    public static class Utilities
    {
        public static uint? BinarySearch<T>(this IList<T> list, IComparable<T> item)
        {
            // Low starts out with the first index, high with the last
            uint low = 0;
            uint high = (uint)list.Count - 1;

            while (true)
            {
                // If low is greater than high the item is not in the list. Return null
                if (low > high)
                {
                    return null;
                }
                // Index in question is the median of low and high ("the middle")
                uint index = ((low + high) / 2);
                var comparison = item.CompareTo(list.ElementAt((int)index));
                // If the item is greater than the item at index increase low to index + 1
                if (comparison > 0) low = index + 1;
                // If the item is less than the item at index decrease high to index - 1
                else if (comparison < 0) high = index - 1;
                // If the item is equal to the item at index return the index
                else return index;
            }
        }

        public static int? BinaryInsert<T>(this IList<T> list, IComparable<T> item)
        {
            // Low starts out with the first index, high with the last
            int low = 0;
            int high = list.Count - 1;

            while (true)
            {
                if (low > high)
                {
                    list.Insert(low, (T)item);
                    return low;
                }
                // Index in question is the median of low and high ("the middle")
                int index = (int)((low + high) / 2);
                var comparison = item.CompareTo(list.ElementAt(index));
                // If the item is greater than the item at index increase low to index + 1
                if (comparison > 0) low = index + 1;
                // If the item is less than the item at index decrease high to index - 1
                else if (comparison < 0) high = index - 1;
                // If the item is equal, meaning already in the list, return null
                else return null;
            }
        }
    }
}

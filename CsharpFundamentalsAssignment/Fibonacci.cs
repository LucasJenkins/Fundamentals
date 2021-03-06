using System;
using System.Collections.Generic;

namespace CsharpFundamentalsAssignment
{
    /**
     * The Fibonacci sequence is simply and recursively defined: the first two elements are `1`, and
     * every other element is equal to the sum of its two preceding elements. For example:
     * <p>
     * [1, 1] =>
     * [1, 1, 1 + 1]  => [1, 1, 2] =>
     * [1, 1, 2, 1 + 2] => [1, 1, 2, 3] =>
     * [1, 1, 2, 3, 2 + 3] => [1, 1, 2, 3, 5] =>
     * ...etc
     */
    public class Fibonacci
    {
        /**
         * Calculates the value in the Fibonacci sequence at a given index. For example,
         * `AtIndex(0)` and `AtIndex(1)` should return `1`, because the first two elements of the
         * sequence are both `1`.
         *
         * @param i the index of the element to calculate
         * @return the calculated element
         * @throws ArgumentException if the given index is less than zero
         */
        public static int AtIndex(int i)
        {
            List<int> list3 = new List<int>();
            int results = 0;

            if (i < 0)
            {
                throw new ArgumentException();
            }
            if (i < 2)
            {
                return 1;
            }
            list3.Add(1);
            list3.Add(1);
            for (int n = 1; n < i; n++)
            {
                results = list3[n] + list3[n - 1];
                list3.Add(results);
            }

            return list3[i];
        }

        /**
         * Calculates a slice of the fibonacci sequence, starting from a given start index (inclusive) and
         * ending at a given end index (exclusive).
         *
         * @param start the starting index of the slice (inclusive)
         * @param end   the ending index of the slice(exclusive)
         * @return the calculated slice as an array of int elements
         * @throws ArgumentException if either the given start or end is negative, or if the
         *                                  given end is less than the given start
         */
        public static int[] Slice(int start, int end)
        {
            List<int> list = new List<int>();

            if (end < start || end < 0 || start < 0)
            {
                throw new ArgumentException();
            }
            for (int i = start; i < end; i++)
            {
                list.Add(AtIndex(i));
            }
            return list.ToArray();
        }

        /**
         * Calculates the beginning of the fibonacci sequence, up to a given count.
         *
         * @param count the number of elements to calculate
         * @return the beginning of the fibonacci sequence, up to the given count, as an array of int elements
         * @throws ArgumentException if the given count is negative
         */
        public static int[] Sequence(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException();
            }
            return Slice(0, count);

        }
    }
}
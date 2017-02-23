/* 
 * Problem description: Given an array of integers, sort the array into a 
 * wave like array and return it, in other words, arrange the elements into 
 * a sequence such that a1 >= a2 <= a3 >= a4 <= a5.....
 */

using System.Collections.Generic;

namespace Wave_Array
{
    public class Solution
    {
        public static List<int> WaveArray(List<int> A)
        {
            // make sure the collection is sorted
            A.Sort();

            // swap evens with odds in the list
            for (int i = 0; i < A.Count; i += 2)
            {
                swap(A, i, i + 1);
            }

            return A;
        }

        ///<summary>swaps given indexes in the List collection</summary>
        ///<param name="data">List collection on which the operation is to be performed</param>  
        ///<param name="a">First swap index</param>
        ///<param name="b">Second swap index</param>
        private static void swap(List<int> data, int a, int b)
        {
            if (b < data.Count)
            {
                int c = data[b];
                data[b] = data[a];
                data[a] = c;
            }
        }
    }
}

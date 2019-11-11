using System;
using System.Collections.Generic;

namespace Lists
{
    public class Searching
    {
        public static int BinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;
            
            while(low<high)
            {
                int mid = (low+high)/2;

                if(array[mid]==value)
                {
                    return mid;
                }
                if(array[mid]<value)
                {
                    low = mid + 1;
                }
                else{
                    high = mid;
                }
            }
            return -1;
        }
    }
}
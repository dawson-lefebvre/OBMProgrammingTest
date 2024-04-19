using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question1 : MonoBehaviour
{
    /*
     * Haha this finally clicked for me in the last 15 minutes of the test.
     * 
     * It seems that this method is search for the index of an item in the int array in a certain range.
     * I believe that the method assumes that the array is sorted in ascending order because the method gets
     * re-called with a higher min or lower max
     * if the item found at the index is less than or greater than the target item.
     */



    int FindIndexInRange(int[] array, int item, int minIndex, int maxIndex)
    {
        int indexToSearch = (minIndex + maxIndex) / 2;

        if (minIndex > maxIndex)
        {
            return -1;
        }

        if (array[indexToSearch] < item)
        {
            return FindIndexInRange(array, item, indexToSearch + 1, maxIndex);
        }
        else if (array[indexToSearch] > item)
        {
            return FindIndexInRange(array, item, minIndex, indexToSearch - 1);
        }
        else
        {
            return indexToSearch;
        }
    }

}

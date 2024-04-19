using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question3 : MonoBehaviour
{
    // Given an array of integers, write a C# function that returns a new array with any duplicate entries removed and the size of the resulting array. 
    // The order of the elements in the array should remain the same. 
    // Use the function signature below. 
    // For example the input array {0, 0, 1, 2, 2, 0, -1} returns the array {0, 1, 2, -1} and size 4.

    public int[] RemoveDuplicatesInArray(int[] array)
    {
        List<int> uniqueInts = new List<int>();
        List<int> duplicateIndexes = new List<int>();
        
        //Find duplicates
        for (int i = 0; i < array.Length; i++)
        {
            if (uniqueInts.Contains(array[i]))
            {
                duplicateIndexes.Add(i);
            }
            else
            {
                uniqueInts.Add(array[i]);
            }
        }

        //Remove duplicates
        int[] cleanArray = new int[array.Length - duplicateIndexes.Count];

        int indexesSkipped = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (duplicateIndexes.Contains(i))
            {
                indexesSkipped++;
                continue;
            }
            else
            {
                cleanArray[i - indexesSkipped] = array[i];
            }
        }

        return cleanArray;
    }
}

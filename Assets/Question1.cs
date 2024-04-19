using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question1 : MonoBehaviour
{
    //This one is tricky. I'll come back to it if I have the time.

    int Func(int[] arr, int a, int b, int c)
    {
        int d = (b + c) / 2;

        if (b > c)
        {
            return -1;
        }

        if (arr[d] < a)
        {
            return Func(arr, a, d + 1, c);
        }
        else if (arr[d] > a)
        {
            return Func(arr, a, b, d - 1);
        }
        else
        {
            return d;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question2 : MonoBehaviour
{
    // Given two 2D axis-aligned bounding boxes, write a C# function that returns TRUE if the two boxes overlap/intersect, FALSE if not. 
    // Define any data structures you will be using or assumptions you need to make. 
    // Describe the test cases that you would use to verify that your algorithm works correctly.

    public bool DoBoundsOverlap(Bounds box1,  Bounds box2)
    {
        if(box1 != null && box2 != null)
        {
            if(box1.Intersects(box2))
            {
                return true;
            }
            else { return false; }
        }
        else if (box1 == null && box2 == null)
        {
            Debug.LogError("DoBoundsOverlap Error: Both boxes are null");
        }
        else if (box1 == null)
        {
            Debug.LogError("DoBoundsOverlap Error: box1 is null");
        }
        else
        {
            Debug.LogError("DoBoundsOverlap Error: box2 is null");
        }
      
        return false;
    }

    /* This method allows the programmer to input 2 Bounding boxes
     * Using Unity's built in Intersect function we determine if the boxes overlap and return the result
     * if both boxes inputted are not null.
     * 
     * To test that this works, we can place two objects with bound boxes in a Unity scene and run the
     * method at various angles, overlapping and not overlapping. To make testing faster, we could even 
     * run the method every Update or FixedUpdate and Debug.Log the results as we move the objects around
     * the scene.
     */
}

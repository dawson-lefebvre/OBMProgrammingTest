using System;

//See follow up questions at the bottom of this file
public struct Vector3D
{
    //Components of the Vector
    public float x;
    public float y;
    public float z;

    //Contructors
    public Vector3D(float x, float y, float z) //Greedy constructor
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3D(float x, float y) //XY only constructor
    {
        this.x = x;
        this.y = y;
        z = 0;
    }

    public float magnitude
    {
        //Calculate magnitude
        get { return MathF.Sqrt((x * x) + (y * y) + (z * z)); }
    }

    //ALL OF THE FOLLOWING METHODS ASSUME THAT A AND B ARE NOT NULL

    public static Vector3D Add(Vector3D A, Vector3D B)
    {
        //Add each component
        float xSum = A.x + B.x;
        float ySum = A.y + B.y;
        float zSum = A.z + B.z;

        //Return new Vector
        return new Vector3D(xSum, ySum, zSum);
    }

    public static float Dot(Vector3D A, Vector3D B)
    {
        //Multiply components
        float a = A.x * B.x;
        float b = A.y * B.y;
        float c = A.z * B.z;

        //Return the sum of the multiplied components
        return a + b + c;
    }

    public static Vector3D Normalize(Vector3D A)
    {
        //Divide each component by the magnitude
        float normX = A.x / A.magnitude;
        float normY = A.y / A.magnitude;
        float normZ = A.z / A.magnitude;

        //Return result
        return new Vector3D(normX, normY, normZ);
    }

    public static bool Equals(Vector3D A, Vector3D B)
    {
        //Check if individual components are equal
        bool xEqual = A.x == B.x;
        bool yEqual = A.y == B.y;
        bool zEqual = A.z == B.z;

        //Check if all components in A are equal to the components of B
        bool allEqual = xEqual && yEqual && zEqual;

        //Return result
        return allEqual;
    }
}

// Followup: 
// - What is the difference between a class and a struct?

/* A class is a reference type, meaning that it points to an area in memory where the values are stored rather than the value itself
 * When passing a instance of a class object, any changes made to the object get saved in memory, whereas a struct will simply copy 
 * the value into wherever it is being used.
 * 
 * Structs also cannot inherit other structs or classes or BE inherited by other structs or classes
 * Structs are often used for simpler data structures because they are less performance heavy than classes
 */

// - What would be the practical differences if this vector were implemented as a class?

/*
 * To be honest, I can't really imagine any practical advantages to using this as a class.
 * I can't see any class ever needing to inherit from it, and vectors are typically more of a datatype rather than something
 * with more functionality.
 * 
 * That, and as I stated before, classes are more performance heavy. Considering this is used for game development where vectors are
 * constantly being used, we'll need all of the performance optimization we can get!
 */
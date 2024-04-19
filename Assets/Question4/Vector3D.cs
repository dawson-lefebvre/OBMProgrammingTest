using System.Collections;
using System.Collections.Generic;

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
}

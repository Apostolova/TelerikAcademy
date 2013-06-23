using System;
using System.Collections.Generic;
using System.Text;


public struct Point3D
{

    public int pointX { get; set; }
    public int pointY { get; set; }
    public int pointZ { get; set; }

   public static readonly Point3D pointZero = new Point3D(0, 0, 0);

    public override string ToString()
    {
        StringBuilder point = new StringBuilder();
        point.Append("Point:" +"("+ pointX+ ",");
        point.Append(pointY + ",");
        point.Append(pointZ + ")");

        return point.ToString();

    }

    public Point3D(int pointX, int pointY, int pointZ)
        : this()
    {
        this.pointX = pointX;
        this.pointY = pointY;
        this.pointZ = pointZ;
    }

    //static int Point3D
    //{
    //    get
    //    {
    //        return Point3D[0];
    //    }
    //}
}
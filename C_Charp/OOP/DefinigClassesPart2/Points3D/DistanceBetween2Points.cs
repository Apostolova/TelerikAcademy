using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3D
{
    static class DistanceBetween2Points
    {
        static double Distance(Point3D pointFirst, Point3D pointSecond)
        {
           double distance = Math.Sqrt(Math.Pow(pointFirst.pointX - pointSecond.pointX, 2) + Math.Pow(pointFirst.pointY - pointSecond.pointY, 2)  + Math.Pow(pointFirst.pointZ - pointSecond.pointZ, 2));
           return distance;
        }

    }
}

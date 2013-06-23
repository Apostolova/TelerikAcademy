using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3D
{
   public class Path
    {
        public List<Point3D> pointsList = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.pointsList;
            }
        }

        public void AddPoint(Point3D point)
        {
            pointsList.Add(point);
        }

        public void ClearPath()
        {
            pointsList.Clear();
        }
    }
}

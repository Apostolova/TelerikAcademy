using System.Collections.Generic;

//task 6
namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        private char[,] trailObjectBody = new char[,] { { '+' } };
        private int trailObjectLifeTime;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, int trailObjectLifeTime) : base(topLeft, speed)
        {
            this.trailObjectLifeTime = trailObjectLifeTime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> tail = new List<TrailObject>();

            // add a new trail object at the current position
            TrailObject trailObject = new TrailObject(this.TopLeft, this.trailObjectBody, this.trailObjectLifeTime);
            tail.Add(trailObject);

            return tail;
        }
    }
}

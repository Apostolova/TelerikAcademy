namespace Minesweeper
{
    using System;
    using System.Linq;

    public class PlayerPoints
    {
        private string name;
        private int points;

        public PlayerPoints()
        {
        }

        public PlayerPoints(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }
    }
}

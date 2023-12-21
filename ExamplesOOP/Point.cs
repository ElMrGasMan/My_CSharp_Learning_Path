using static System.Math;

namespace ExamplesOOP
{
    internal class Point
    {
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Point() 
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Uses the Pythagoras theorem to calculate the distance between 2 x and y points.
        /// </summary>
        /// <param name="point"> Another x and y point </param>
        /// <returns> A not rounded double that's the distance between the base point and the parameter point </returns>
        public double DistanceTo(Point point) 
        {
            return Sqrt(Pow(point.X - x, 2) + Pow(point.Y - y, 2));
        }

        public override string? ToString()
        {
            return $"({x},{y})";
        }
    }
}

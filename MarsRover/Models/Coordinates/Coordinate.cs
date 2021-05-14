namespace MarsRover.Models.Coordinates
{
    public class Coordinate : ICoordinate
    {
        public Coordinate(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}

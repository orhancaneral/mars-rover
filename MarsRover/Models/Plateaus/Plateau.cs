namespace MarsRover.Models.Plateaus
{
    public class Plateau : IPlateau
    {
        public Plateau(int width, int depth, int height)
        {
            Width = width;
            Depth = depth;
            Height = height;
        }
        public int Width { get; }
        public int Depth { get; }
        public int Height { get; }
    }
}
